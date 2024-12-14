using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007AB RID: 1963
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueBuffEnhanceInfoScRsp : IMessage<GetRogueBuffEnhanceInfoScRsp>, IMessage, IEquatable<GetRogueBuffEnhanceInfoScRsp>, IDeepCloneable<GetRogueBuffEnhanceInfoScRsp>, IBufferMessage
	{
		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x060057A1 RID: 22433 RVA: 0x000EA987 File Offset: 0x000E8B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueBuffEnhanceInfoScRsp> Parser
		{
			get
			{
				return GetRogueBuffEnhanceInfoScRsp._parser;
			}
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x060057A2 RID: 22434 RVA: 0x000EA98E File Offset: 0x000E8B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueBuffEnhanceInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x060057A3 RID: 22435 RVA: 0x000EA9A0 File Offset: 0x000E8BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueBuffEnhanceInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060057A4 RID: 22436 RVA: 0x000EA9A7 File Offset: 0x000E8BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueBuffEnhanceInfoScRsp()
		{
		}

		// Token: 0x060057A5 RID: 22437 RVA: 0x000EA9B0 File Offset: 0x000E8BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueBuffEnhanceInfoScRsp(GetRogueBuffEnhanceInfoScRsp other) : this()
		{
			this.buffEnhanceInfo_ = ((other.buffEnhanceInfo_ != null) ? other.buffEnhanceInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x000EA9FC File Offset: 0x000E8BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueBuffEnhanceInfoScRsp Clone()
		{
			return new GetRogueBuffEnhanceInfoScRsp(this);
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x060057A7 RID: 22439 RVA: 0x000EAA04 File Offset: 0x000E8C04
		// (set) Token: 0x060057A8 RID: 22440 RVA: 0x000EAA0C File Offset: 0x000E8C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffEnhanceInfoList BuffEnhanceInfo
		{
			get
			{
				return this.buffEnhanceInfo_;
			}
			set
			{
				this.buffEnhanceInfo_ = value;
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x060057A9 RID: 22441 RVA: 0x000EAA15 File Offset: 0x000E8C15
		// (set) Token: 0x060057AA RID: 22442 RVA: 0x000EAA1D File Offset: 0x000E8C1D
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

		// Token: 0x060057AB RID: 22443 RVA: 0x000EAA26 File Offset: 0x000E8C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueBuffEnhanceInfoScRsp);
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x000EAA34 File Offset: 0x000E8C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueBuffEnhanceInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BuffEnhanceInfo, other.BuffEnhanceInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x000EAA84 File Offset: 0x000E8C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.buffEnhanceInfo_ != null)
			{
				num ^= this.BuffEnhanceInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x000EAAD9 File Offset: 0x000E8CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x000EAAE1 File Offset: 0x000E8CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x000EAAEC File Offset: 0x000E8CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.buffEnhanceInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.BuffEnhanceInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x000EAB48 File Offset: 0x000E8D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.buffEnhanceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuffEnhanceInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x000EABA0 File Offset: 0x000E8DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueBuffEnhanceInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.buffEnhanceInfo_ != null)
			{
				if (this.buffEnhanceInfo_ == null)
				{
					this.BuffEnhanceInfo = new RogueBuffEnhanceInfoList();
				}
				this.BuffEnhanceInfo.MergeFrom(other.BuffEnhanceInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x000EAC08 File Offset: 0x000E8E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x000EAC14 File Offset: 0x000E8E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.buffEnhanceInfo_ == null)
						{
							this.BuffEnhanceInfo = new RogueBuffEnhanceInfoList();
						}
						input.ReadMessage(this.BuffEnhanceInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002237 RID: 8759
		private static readonly MessageParser<GetRogueBuffEnhanceInfoScRsp> _parser = new MessageParser<GetRogueBuffEnhanceInfoScRsp>(() => new GetRogueBuffEnhanceInfoScRsp());

		// Token: 0x04002238 RID: 8760
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002239 RID: 8761
		public const int BuffEnhanceInfoFieldNumber = 14;

		// Token: 0x0400223A RID: 8762
		private RogueBuffEnhanceInfoList buffEnhanceInfo_;

		// Token: 0x0400223B RID: 8763
		public const int RetcodeFieldNumber = 11;

		// Token: 0x0400223C RID: 8764
		private uint retcode_;
	}
}
