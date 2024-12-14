using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004BB RID: 1211
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildShopAbilityDownScRsp : IMessage<EvolveBuildShopAbilityDownScRsp>, IMessage, IEquatable<EvolveBuildShopAbilityDownScRsp>, IDeepCloneable<EvolveBuildShopAbilityDownScRsp>, IBufferMessage
	{
		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x00094EB5 File Offset: 0x000930B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildShopAbilityDownScRsp> Parser
		{
			get
			{
				return EvolveBuildShopAbilityDownScRsp._parser;
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06003621 RID: 13857 RVA: 0x00094EBC File Offset: 0x000930BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildShopAbilityDownScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06003622 RID: 13858 RVA: 0x00094ECE File Offset: 0x000930CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildShopAbilityDownScRsp.Descriptor;
			}
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x00094ED5 File Offset: 0x000930D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityDownScRsp()
		{
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x00094EDD File Offset: 0x000930DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityDownScRsp(EvolveBuildShopAbilityDownScRsp other) : this()
		{
			this.level_ = other.level_;
			this.retcode_ = other.retcode_;
			this.iCKOBLBOKIH_ = other.iCKOBLBOKIH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x00094F1A File Offset: 0x0009311A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityDownScRsp Clone()
		{
			return new EvolveBuildShopAbilityDownScRsp(this);
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06003626 RID: 13862 RVA: 0x00094F22 File Offset: 0x00093122
		// (set) Token: 0x06003627 RID: 13863 RVA: 0x00094F2A File Offset: 0x0009312A
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

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06003628 RID: 13864 RVA: 0x00094F33 File Offset: 0x00093133
		// (set) Token: 0x06003629 RID: 13865 RVA: 0x00094F3B File Offset: 0x0009313B
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

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x0600362A RID: 13866 RVA: 0x00094F44 File Offset: 0x00093144
		// (set) Token: 0x0600362B RID: 13867 RVA: 0x00094F4C File Offset: 0x0009314C
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

		// Token: 0x0600362C RID: 13868 RVA: 0x00094F55 File Offset: 0x00093155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildShopAbilityDownScRsp);
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x00094F64 File Offset: 0x00093164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildShopAbilityDownScRsp other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.Retcode == other.Retcode && this.ICKOBLBOKIH == other.ICKOBLBOKIH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x00094FC0 File Offset: 0x000931C0
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

		// Token: 0x0600362F RID: 13871 RVA: 0x00095031 File Offset: 0x00093231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00095039 File Offset: 0x00093239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x00095044 File Offset: 0x00093244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Level);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ICKOBLBOKIH != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ICKOBLBOKIH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x000950BC File Offset: 0x000932BC
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

		// Token: 0x06003633 RID: 13875 RVA: 0x0009512C File Offset: 0x0009332C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildShopAbilityDownScRsp other)
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

		// Token: 0x06003634 RID: 13876 RVA: 0x00095190 File Offset: 0x00093390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x0009519C File Offset: 0x0009339C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ICKOBLBOKIH = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400158B RID: 5515
		private static readonly MessageParser<EvolveBuildShopAbilityDownScRsp> _parser = new MessageParser<EvolveBuildShopAbilityDownScRsp>(() => new EvolveBuildShopAbilityDownScRsp());

		// Token: 0x0400158C RID: 5516
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400158D RID: 5517
		public const int LevelFieldNumber = 3;

		// Token: 0x0400158E RID: 5518
		private uint level_;

		// Token: 0x0400158F RID: 5519
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04001590 RID: 5520
		private uint retcode_;

		// Token: 0x04001591 RID: 5521
		public const int ICKOBLBOKIHFieldNumber = 14;

		// Token: 0x04001592 RID: 5522
		private uint iCKOBLBOKIH_;
	}
}
