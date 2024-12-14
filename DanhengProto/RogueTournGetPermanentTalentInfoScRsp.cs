using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FD3 RID: 4051
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGetPermanentTalentInfoScRsp : IMessage<RogueTournGetPermanentTalentInfoScRsp>, IMessage, IEquatable<RogueTournGetPermanentTalentInfoScRsp>, IDeepCloneable<RogueTournGetPermanentTalentInfoScRsp>, IBufferMessage
	{
		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0600B473 RID: 46195 RVA: 0x001E43AB File Offset: 0x001E25AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGetPermanentTalentInfoScRsp> Parser
		{
			get
			{
				return RogueTournGetPermanentTalentInfoScRsp._parser;
			}
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0600B474 RID: 46196 RVA: 0x001E43B2 File Offset: 0x001E25B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGetPermanentTalentInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x0600B475 RID: 46197 RVA: 0x001E43C4 File Offset: 0x001E25C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGetPermanentTalentInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600B476 RID: 46198 RVA: 0x001E43CB File Offset: 0x001E25CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetPermanentTalentInfoScRsp()
		{
		}

		// Token: 0x0600B477 RID: 46199 RVA: 0x001E43D4 File Offset: 0x001E25D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetPermanentTalentInfoScRsp(RogueTournGetPermanentTalentInfoScRsp other) : this()
		{
			this.permanentInfo_ = ((other.permanentInfo_ != null) ? other.permanentInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B478 RID: 46200 RVA: 0x001E4420 File Offset: 0x001E2620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetPermanentTalentInfoScRsp Clone()
		{
			return new RogueTournGetPermanentTalentInfoScRsp(this);
		}

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x0600B479 RID: 46201 RVA: 0x001E4428 File Offset: 0x001E2628
		// (set) Token: 0x0600B47A RID: 46202 RVA: 0x001E4430 File Offset: 0x001E2630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournPermanentTalentInfo PermanentInfo
		{
			get
			{
				return this.permanentInfo_;
			}
			set
			{
				this.permanentInfo_ = value;
			}
		}

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x0600B47B RID: 46203 RVA: 0x001E4439 File Offset: 0x001E2639
		// (set) Token: 0x0600B47C RID: 46204 RVA: 0x001E4441 File Offset: 0x001E2641
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

		// Token: 0x0600B47D RID: 46205 RVA: 0x001E444A File Offset: 0x001E264A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGetPermanentTalentInfoScRsp);
		}

		// Token: 0x0600B47E RID: 46206 RVA: 0x001E4458 File Offset: 0x001E2658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGetPermanentTalentInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.PermanentInfo, other.PermanentInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B47F RID: 46207 RVA: 0x001E44A8 File Offset: 0x001E26A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.permanentInfo_ != null)
			{
				num ^= this.PermanentInfo.GetHashCode();
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

		// Token: 0x0600B480 RID: 46208 RVA: 0x001E44FD File Offset: 0x001E26FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B481 RID: 46209 RVA: 0x001E4505 File Offset: 0x001E2705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x001E4510 File Offset: 0x001E2710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.permanentInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PermanentInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B483 RID: 46211 RVA: 0x001E456C File Offset: 0x001E276C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.permanentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PermanentInfo);
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

		// Token: 0x0600B484 RID: 46212 RVA: 0x001E45C4 File Offset: 0x001E27C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGetPermanentTalentInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.permanentInfo_ != null)
			{
				if (this.permanentInfo_ == null)
				{
					this.PermanentInfo = new RogueTournPermanentTalentInfo();
				}
				this.PermanentInfo.MergeFrom(other.PermanentInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x001E462C File Offset: 0x001E282C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B486 RID: 46214 RVA: 0x001E4638 File Offset: 0x001E2838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 80U)
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
					if (this.permanentInfo_ == null)
					{
						this.PermanentInfo = new RogueTournPermanentTalentInfo();
					}
					input.ReadMessage(this.PermanentInfo);
				}
			}
		}

		// Token: 0x04004924 RID: 18724
		private static readonly MessageParser<RogueTournGetPermanentTalentInfoScRsp> _parser = new MessageParser<RogueTournGetPermanentTalentInfoScRsp>(() => new RogueTournGetPermanentTalentInfoScRsp());

		// Token: 0x04004925 RID: 18725
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004926 RID: 18726
		public const int PermanentInfoFieldNumber = 1;

		// Token: 0x04004927 RID: 18727
		private RogueTournPermanentTalentInfo permanentInfo_;

		// Token: 0x04004928 RID: 18728
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04004929 RID: 18729
		private uint retcode_;
	}
}
