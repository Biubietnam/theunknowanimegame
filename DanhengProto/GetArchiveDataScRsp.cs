using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000619 RID: 1561
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetArchiveDataScRsp : IMessage<GetArchiveDataScRsp>, IMessage, IEquatable<GetArchiveDataScRsp>, IDeepCloneable<GetArchiveDataScRsp>, IBufferMessage
	{
		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x060045F9 RID: 17913 RVA: 0x000BF9C1 File Offset: 0x000BDBC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetArchiveDataScRsp> Parser
		{
			get
			{
				return GetArchiveDataScRsp._parser;
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x000BF9C8 File Offset: 0x000BDBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetArchiveDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060045FB RID: 17915 RVA: 0x000BF9DA File Offset: 0x000BDBDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetArchiveDataScRsp.Descriptor;
			}
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x000BF9E1 File Offset: 0x000BDBE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetArchiveDataScRsp()
		{
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x000BF9EC File Offset: 0x000BDBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetArchiveDataScRsp(GetArchiveDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.archiveData_ = ((other.archiveData_ != null) ? other.archiveData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x000BFA38 File Offset: 0x000BDC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetArchiveDataScRsp Clone()
		{
			return new GetArchiveDataScRsp(this);
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060045FF RID: 17919 RVA: 0x000BFA40 File Offset: 0x000BDC40
		// (set) Token: 0x06004600 RID: 17920 RVA: 0x000BFA48 File Offset: 0x000BDC48
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

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x06004601 RID: 17921 RVA: 0x000BFA51 File Offset: 0x000BDC51
		// (set) Token: 0x06004602 RID: 17922 RVA: 0x000BFA59 File Offset: 0x000BDC59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveData ArchiveData
		{
			get
			{
				return this.archiveData_;
			}
			set
			{
				this.archiveData_ = value;
			}
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x000BFA62 File Offset: 0x000BDC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetArchiveDataScRsp);
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x000BFA70 File Offset: 0x000BDC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetArchiveDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.ArchiveData, other.ArchiveData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x000BFAC0 File Offset: 0x000BDCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.archiveData_ != null)
			{
				num ^= this.ArchiveData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x000BFB15 File Offset: 0x000BDD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x000BFB1D File Offset: 0x000BDD1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x000BFB28 File Offset: 0x000BDD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.archiveData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ArchiveData);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x000BFB84 File Offset: 0x000BDD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.archiveData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ArchiveData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x000BFBDC File Offset: 0x000BDDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetArchiveDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.archiveData_ != null)
			{
				if (this.archiveData_ == null)
				{
					this.ArchiveData = new ArchiveData();
				}
				this.ArchiveData.MergeFrom(other.ArchiveData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x000BFC44 File Offset: 0x000BDE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x000BFC50 File Offset: 0x000BDE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 88U)
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
					if (this.archiveData_ == null)
					{
						this.ArchiveData = new ArchiveData();
					}
					input.ReadMessage(this.ArchiveData);
				}
			}
		}

		// Token: 0x04001BF8 RID: 7160
		private static readonly MessageParser<GetArchiveDataScRsp> _parser = new MessageParser<GetArchiveDataScRsp>(() => new GetArchiveDataScRsp());

		// Token: 0x04001BF9 RID: 7161
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BFA RID: 7162
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04001BFB RID: 7163
		private uint retcode_;

		// Token: 0x04001BFC RID: 7164
		public const int ArchiveDataFieldNumber = 4;

		// Token: 0x04001BFD RID: 7165
		private ArchiveData archiveData_;
	}
}
