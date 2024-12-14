using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200093D RID: 2365
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractTreasureDungeonGridScRsp : IMessage<InteractTreasureDungeonGridScRsp>, IMessage, IEquatable<InteractTreasureDungeonGridScRsp>, IDeepCloneable<InteractTreasureDungeonGridScRsp>, IBufferMessage
	{
		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06006989 RID: 27017 RVA: 0x00119B6F File Offset: 0x00117D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InteractTreasureDungeonGridScRsp> Parser
		{
			get
			{
				return InteractTreasureDungeonGridScRsp._parser;
			}
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x0600698A RID: 27018 RVA: 0x00119B76 File Offset: 0x00117D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InteractTreasureDungeonGridScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x0600698B RID: 27019 RVA: 0x00119B88 File Offset: 0x00117D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractTreasureDungeonGridScRsp.Descriptor;
			}
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x00119B8F File Offset: 0x00117D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractTreasureDungeonGridScRsp()
		{
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x00119B98 File Offset: 0x00117D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractTreasureDungeonGridScRsp(InteractTreasureDungeonGridScRsp other) : this()
		{
			this.lHIECKPJNFD_ = ((other.lHIECKPJNFD_ != null) ? other.lHIECKPJNFD_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600698E RID: 27022 RVA: 0x00119BE4 File Offset: 0x00117DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractTreasureDungeonGridScRsp Clone()
		{
			return new InteractTreasureDungeonGridScRsp(this);
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x0600698F RID: 27023 RVA: 0x00119BEC File Offset: 0x00117DEC
		// (set) Token: 0x06006990 RID: 27024 RVA: 0x00119BF4 File Offset: 0x00117DF4
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

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06006991 RID: 27025 RVA: 0x00119BFD File Offset: 0x00117DFD
		// (set) Token: 0x06006992 RID: 27026 RVA: 0x00119C05 File Offset: 0x00117E05
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

		// Token: 0x06006993 RID: 27027 RVA: 0x00119C0E File Offset: 0x00117E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractTreasureDungeonGridScRsp);
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x00119C1C File Offset: 0x00117E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractTreasureDungeonGridScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.LHIECKPJNFD, other.LHIECKPJNFD) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006995 RID: 27029 RVA: 0x00119C6C File Offset: 0x00117E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lHIECKPJNFD_ != null)
			{
				num ^= this.LHIECKPJNFD.GetHashCode();
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

		// Token: 0x06006996 RID: 27030 RVA: 0x00119CC1 File Offset: 0x00117EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006997 RID: 27031 RVA: 0x00119CC9 File Offset: 0x00117EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006998 RID: 27032 RVA: 0x00119CD4 File Offset: 0x00117ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.lHIECKPJNFD_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.LHIECKPJNFD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006999 RID: 27033 RVA: 0x00119D2C File Offset: 0x00117F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lHIECKPJNFD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LHIECKPJNFD);
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

		// Token: 0x0600699A RID: 27034 RVA: 0x00119D84 File Offset: 0x00117F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractTreasureDungeonGridScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lHIECKPJNFD_ != null)
			{
				if (this.lHIECKPJNFD_ == null)
				{
					this.LHIECKPJNFD = new TreasureDungeonLevel();
				}
				this.LHIECKPJNFD.MergeFrom(other.LHIECKPJNFD);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600699B RID: 27035 RVA: 0x00119DEC File Offset: 0x00117FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600699C RID: 27036 RVA: 0x00119DF8 File Offset: 0x00117FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 50U)
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

		// Token: 0x04002871 RID: 10353
		private static readonly MessageParser<InteractTreasureDungeonGridScRsp> _parser = new MessageParser<InteractTreasureDungeonGridScRsp>(() => new InteractTreasureDungeonGridScRsp());

		// Token: 0x04002872 RID: 10354
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002873 RID: 10355
		public const int LHIECKPJNFDFieldNumber = 6;

		// Token: 0x04002874 RID: 10356
		private TreasureDungeonLevel lHIECKPJNFD_;

		// Token: 0x04002875 RID: 10357
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04002876 RID: 10358
		private uint retcode_;
	}
}
