using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200120F RID: 4623
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SummonPunkLordMonsterScRsp : IMessage<SummonPunkLordMonsterScRsp>, IMessage, IEquatable<SummonPunkLordMonsterScRsp>, IDeepCloneable<SummonPunkLordMonsterScRsp>, IBufferMessage
	{
		// Token: 0x17003A44 RID: 14916
		// (get) Token: 0x0600CE9F RID: 52895 RVA: 0x0022A22D File Offset: 0x0022842D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SummonPunkLordMonsterScRsp> Parser
		{
			get
			{
				return SummonPunkLordMonsterScRsp._parser;
			}
		}

		// Token: 0x17003A45 RID: 14917
		// (get) Token: 0x0600CEA0 RID: 52896 RVA: 0x0022A234 File Offset: 0x00228434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SummonPunkLordMonsterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A46 RID: 14918
		// (get) Token: 0x0600CEA1 RID: 52897 RVA: 0x0022A246 File Offset: 0x00228446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonPunkLordMonsterScRsp.Descriptor;
			}
		}

		// Token: 0x0600CEA2 RID: 52898 RVA: 0x0022A24D File Offset: 0x0022844D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonPunkLordMonsterScRsp()
		{
		}

		// Token: 0x0600CEA3 RID: 52899 RVA: 0x0022A258 File Offset: 0x00228458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonPunkLordMonsterScRsp(SummonPunkLordMonsterScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.iOEBEBCENHO_ = ((other.iOEBEBCENHO_ != null) ? other.iOEBEBCENHO_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CEA4 RID: 52900 RVA: 0x0022A2A4 File Offset: 0x002284A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonPunkLordMonsterScRsp Clone()
		{
			return new SummonPunkLordMonsterScRsp(this);
		}

		// Token: 0x17003A47 RID: 14919
		// (get) Token: 0x0600CEA5 RID: 52901 RVA: 0x0022A2AC File Offset: 0x002284AC
		// (set) Token: 0x0600CEA6 RID: 52902 RVA: 0x0022A2B4 File Offset: 0x002284B4
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

		// Token: 0x17003A48 RID: 14920
		// (get) Token: 0x0600CEA7 RID: 52903 RVA: 0x0022A2BD File Offset: 0x002284BD
		// (set) Token: 0x0600CEA8 RID: 52904 RVA: 0x0022A2C5 File Offset: 0x002284C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MGLAPEBCMOO IOEBEBCENHO
		{
			get
			{
				return this.iOEBEBCENHO_;
			}
			set
			{
				this.iOEBEBCENHO_ = value;
			}
		}

		// Token: 0x0600CEA9 RID: 52905 RVA: 0x0022A2CE File Offset: 0x002284CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonPunkLordMonsterScRsp);
		}

		// Token: 0x0600CEAA RID: 52906 RVA: 0x0022A2DC File Offset: 0x002284DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonPunkLordMonsterScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.IOEBEBCENHO, other.IOEBEBCENHO) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CEAB RID: 52907 RVA: 0x0022A32C File Offset: 0x0022852C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.iOEBEBCENHO_ != null)
			{
				num ^= this.IOEBEBCENHO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CEAC RID: 52908 RVA: 0x0022A381 File Offset: 0x00228581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CEAD RID: 52909 RVA: 0x0022A389 File Offset: 0x00228589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CEAE RID: 52910 RVA: 0x0022A394 File Offset: 0x00228594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.iOEBEBCENHO_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.IOEBEBCENHO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CEAF RID: 52911 RVA: 0x0022A3F0 File Offset: 0x002285F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.iOEBEBCENHO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IOEBEBCENHO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CEB0 RID: 52912 RVA: 0x0022A448 File Offset: 0x00228648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonPunkLordMonsterScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.iOEBEBCENHO_ != null)
			{
				if (this.iOEBEBCENHO_ == null)
				{
					this.IOEBEBCENHO = new MGLAPEBCMOO();
				}
				this.IOEBEBCENHO.MergeFrom(other.IOEBEBCENHO);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CEB1 RID: 52913 RVA: 0x0022A4B0 File Offset: 0x002286B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CEB2 RID: 52914 RVA: 0x0022A4BC File Offset: 0x002286BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.iOEBEBCENHO_ == null)
						{
							this.IOEBEBCENHO = new MGLAPEBCMOO();
						}
						input.ReadMessage(this.IOEBEBCENHO);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005335 RID: 21301
		private static readonly MessageParser<SummonPunkLordMonsterScRsp> _parser = new MessageParser<SummonPunkLordMonsterScRsp>(() => new SummonPunkLordMonsterScRsp());

		// Token: 0x04005336 RID: 21302
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005337 RID: 21303
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04005338 RID: 21304
		private uint retcode_;

		// Token: 0x04005339 RID: 21305
		public const int IOEBEBCENHOFieldNumber = 15;

		// Token: 0x0400533A RID: 21306
		private MGLAPEBCMOO iOEBEBCENHO_;
	}
}
