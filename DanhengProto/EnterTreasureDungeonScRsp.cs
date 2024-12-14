using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200047D RID: 1149
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterTreasureDungeonScRsp : IMessage<EnterTreasureDungeonScRsp>, IMessage, IEquatable<EnterTreasureDungeonScRsp>, IDeepCloneable<EnterTreasureDungeonScRsp>, IBufferMessage
	{
		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x0600332E RID: 13102 RVA: 0x0008CC4F File Offset: 0x0008AE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterTreasureDungeonScRsp> Parser
		{
			get
			{
				return EnterTreasureDungeonScRsp._parser;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x0600332F RID: 13103 RVA: 0x0008CC56 File Offset: 0x0008AE56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterTreasureDungeonScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06003330 RID: 13104 RVA: 0x0008CC68 File Offset: 0x0008AE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterTreasureDungeonScRsp.Descriptor;
			}
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x0008CC6F File Offset: 0x0008AE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTreasureDungeonScRsp()
		{
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x0008CC78 File Offset: 0x0008AE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTreasureDungeonScRsp(EnterTreasureDungeonScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.lHIECKPJNFD_ = ((other.lHIECKPJNFD_ != null) ? other.lHIECKPJNFD_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x0008CCC4 File Offset: 0x0008AEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTreasureDungeonScRsp Clone()
		{
			return new EnterTreasureDungeonScRsp(this);
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06003334 RID: 13108 RVA: 0x0008CCCC File Offset: 0x0008AECC
		// (set) Token: 0x06003335 RID: 13109 RVA: 0x0008CCD4 File Offset: 0x0008AED4
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

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06003336 RID: 13110 RVA: 0x0008CCDD File Offset: 0x0008AEDD
		// (set) Token: 0x06003337 RID: 13111 RVA: 0x0008CCE5 File Offset: 0x0008AEE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonLevel LHIECKPJNFD
		{
			get
			{
				return this.lHIECKPJNFD_;
			}
			set
			{
				this.lHIECKPJNFD_ = value;
			}
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x0008CCEE File Offset: 0x0008AEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterTreasureDungeonScRsp);
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x0008CCFC File Offset: 0x0008AEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterTreasureDungeonScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.LHIECKPJNFD, other.LHIECKPJNFD) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x0008CD4C File Offset: 0x0008AF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.lHIECKPJNFD_ != null)
			{
				num ^= this.LHIECKPJNFD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x0008CDA1 File Offset: 0x0008AFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x0008CDA9 File Offset: 0x0008AFA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x0008CDB4 File Offset: 0x0008AFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.lHIECKPJNFD_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.LHIECKPJNFD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x0008CE10 File Offset: 0x0008B010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.lHIECKPJNFD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LHIECKPJNFD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x0008CE68 File Offset: 0x0008B068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterTreasureDungeonScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.lHIECKPJNFD_ != null)
			{
				if (this.lHIECKPJNFD_ == null)
				{
					this.LHIECKPJNFD = new TreasureDungeonLevel();
				}
				this.LHIECKPJNFD.MergeFrom(other.LHIECKPJNFD);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x0008CED0 File Offset: 0x0008B0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x0008CEDC File Offset: 0x0008B0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.lHIECKPJNFD_ == null)
						{
							this.LHIECKPJNFD = new TreasureDungeonLevel();
						}
						input.ReadMessage(this.LHIECKPJNFD);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400145E RID: 5214
		private static readonly MessageParser<EnterTreasureDungeonScRsp> _parser = new MessageParser<EnterTreasureDungeonScRsp>(() => new EnterTreasureDungeonScRsp());

		// Token: 0x0400145F RID: 5215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001460 RID: 5216
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04001461 RID: 5217
		private uint retcode_;

		// Token: 0x04001462 RID: 5218
		public const int LHIECKPJNFDFieldNumber = 13;

		// Token: 0x04001463 RID: 5219
		private TreasureDungeonLevel lHIECKPJNFD_;
	}
}
