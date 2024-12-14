using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004C3 RID: 1219
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildShopAbilityUpScRsp : IMessage<EvolveBuildShopAbilityUpScRsp>, IMessage, IEquatable<EvolveBuildShopAbilityUpScRsp>, IDeepCloneable<EvolveBuildShopAbilityUpScRsp>, IBufferMessage
	{
		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x0600367B RID: 13947 RVA: 0x00095BB5 File Offset: 0x00093DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildShopAbilityUpScRsp> Parser
		{
			get
			{
				return EvolveBuildShopAbilityUpScRsp._parser;
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x0600367C RID: 13948 RVA: 0x00095BBC File Offset: 0x00093DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildShopAbilityUpScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x0600367D RID: 13949 RVA: 0x00095BCE File Offset: 0x00093DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildShopAbilityUpScRsp.Descriptor;
			}
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x00095BD5 File Offset: 0x00093DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityUpScRsp()
		{
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x00095BDD File Offset: 0x00093DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityUpScRsp(EvolveBuildShopAbilityUpScRsp other) : this()
		{
			this.level_ = other.level_;
			this.retcode_ = other.retcode_;
			this.iCKOBLBOKIH_ = other.iCKOBLBOKIH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x00095C1A File Offset: 0x00093E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityUpScRsp Clone()
		{
			return new EvolveBuildShopAbilityUpScRsp(this);
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06003681 RID: 13953 RVA: 0x00095C22 File Offset: 0x00093E22
		// (set) Token: 0x06003682 RID: 13954 RVA: 0x00095C2A File Offset: 0x00093E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06003683 RID: 13955 RVA: 0x00095C33 File Offset: 0x00093E33
		// (set) Token: 0x06003684 RID: 13956 RVA: 0x00095C3B File Offset: 0x00093E3B
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

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06003685 RID: 13957 RVA: 0x00095C44 File Offset: 0x00093E44
		// (set) Token: 0x06003686 RID: 13958 RVA: 0x00095C4C File Offset: 0x00093E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ICKOBLBOKIH
		{
			get
			{
				return this.iCKOBLBOKIH_;
			}
			set
			{
				this.iCKOBLBOKIH_ = value;
			}
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x00095C55 File Offset: 0x00093E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildShopAbilityUpScRsp);
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x00095C64 File Offset: 0x00093E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildShopAbilityUpScRsp other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.Retcode == other.Retcode && this.ICKOBLBOKIH == other.ICKOBLBOKIH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x00095CC0 File Offset: 0x00093EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ICKOBLBOKIH != 0U)
			{
				num ^= this.ICKOBLBOKIH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x00095D31 File Offset: 0x00093F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x00095D39 File Offset: 0x00093F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x00095D44 File Offset: 0x00093F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ICKOBLBOKIH != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ICKOBLBOKIH);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x00095DBC File Offset: 0x00093FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ICKOBLBOKIH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ICKOBLBOKIH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00095E2C File Offset: 0x0009402C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildShopAbilityUpScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ICKOBLBOKIH != 0U)
			{
				this.ICKOBLBOKIH = other.ICKOBLBOKIH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00095E90 File Offset: 0x00094090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x00095E9C File Offset: 0x0009409C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 40U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Level = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.ICKOBLBOKIH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040015A8 RID: 5544
		private static readonly MessageParser<EvolveBuildShopAbilityUpScRsp> _parser = new MessageParser<EvolveBuildShopAbilityUpScRsp>(() => new EvolveBuildShopAbilityUpScRsp());

		// Token: 0x040015A9 RID: 5545
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015AA RID: 5546
		public const int LevelFieldNumber = 9;

		// Token: 0x040015AB RID: 5547
		private uint level_;

		// Token: 0x040015AC RID: 5548
		public const int RetcodeFieldNumber = 5;

		// Token: 0x040015AD RID: 5549
		private uint retcode_;

		// Token: 0x040015AE RID: 5550
		public const int ICKOBLBOKIHFieldNumber = 2;

		// Token: 0x040015AF RID: 5551
		private uint iCKOBLBOKIH_;
	}
}
