using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004E1 RID: 1249
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeRogueRewardKeyScRsp : IMessage<ExchangeRogueRewardKeyScRsp>, IMessage, IEquatable<ExchangeRogueRewardKeyScRsp>, IDeepCloneable<ExchangeRogueRewardKeyScRsp>, IBufferMessage
	{
		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x060037D9 RID: 14297 RVA: 0x00099131 File Offset: 0x00097331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeRogueRewardKeyScRsp> Parser
		{
			get
			{
				return ExchangeRogueRewardKeyScRsp._parser;
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x060037DA RID: 14298 RVA: 0x00099138 File Offset: 0x00097338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExchangeRogueRewardKeyScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x060037DB RID: 14299 RVA: 0x0009914A File Offset: 0x0009734A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeRogueRewardKeyScRsp.Descriptor;
			}
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x00099151 File Offset: 0x00097351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRogueRewardKeyScRsp()
		{
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x00099159 File Offset: 0x00097359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRogueRewardKeyScRsp(ExchangeRogueRewardKeyScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x0009918A File Offset: 0x0009738A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRogueRewardKeyScRsp Clone()
		{
			return new ExchangeRogueRewardKeyScRsp(this);
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x060037DF RID: 14303 RVA: 0x00099192 File Offset: 0x00097392
		// (set) Token: 0x060037E0 RID: 14304 RVA: 0x0009919A File Offset: 0x0009739A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x000991A3 File Offset: 0x000973A3
		// (set) Token: 0x060037E2 RID: 14306 RVA: 0x000991AB File Offset: 0x000973AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x000991B4 File Offset: 0x000973B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeRogueRewardKeyScRsp);
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x000991C2 File Offset: 0x000973C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeRogueRewardKeyScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x00099200 File Offset: 0x00097400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Count != 0U)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x00099258 File Offset: 0x00097458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x00099260 File Offset: 0x00097460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x0009926C File Offset: 0x0009746C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Count);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x000992C8 File Offset: 0x000974C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Count != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x00099320 File Offset: 0x00097520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeRogueRewardKeyScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Count != 0U)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00099370 File Offset: 0x00097570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x0009937C File Offset: 0x0009757C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.Count = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001618 RID: 5656
		private static readonly MessageParser<ExchangeRogueRewardKeyScRsp> _parser = new MessageParser<ExchangeRogueRewardKeyScRsp>(() => new ExchangeRogueRewardKeyScRsp());

		// Token: 0x04001619 RID: 5657
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400161A RID: 5658
		public const int RetcodeFieldNumber = 7;

		// Token: 0x0400161B RID: 5659
		private uint retcode_;

		// Token: 0x0400161C RID: 5660
		public const int CountFieldNumber = 2;

		// Token: 0x0400161D RID: 5661
		private uint count_;
	}
}
