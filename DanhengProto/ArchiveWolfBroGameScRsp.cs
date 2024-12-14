using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000B1 RID: 177
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArchiveWolfBroGameScRsp : IMessage<ArchiveWolfBroGameScRsp>, IMessage, IEquatable<ArchiveWolfBroGameScRsp>, IDeepCloneable<ArchiveWolfBroGameScRsp>, IBufferMessage
	{
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00015AF7 File Offset: 0x00013CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArchiveWolfBroGameScRsp> Parser
		{
			get
			{
				return ArchiveWolfBroGameScRsp._parser;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00015AFE File Offset: 0x00013CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ArchiveWolfBroGameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00015B10 File Offset: 0x00013D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArchiveWolfBroGameScRsp.Descriptor;
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00015B17 File Offset: 0x00013D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveWolfBroGameScRsp()
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00015B20 File Offset: 0x00013D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveWolfBroGameScRsp(ArchiveWolfBroGameScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.wolfBroGameData_ = ((other.wolfBroGameData_ != null) ? other.wolfBroGameData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00015B6C File Offset: 0x00013D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveWolfBroGameScRsp Clone()
		{
			return new ArchiveWolfBroGameScRsp(this);
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x00015B74 File Offset: 0x00013D74
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x00015B7C File Offset: 0x00013D7C
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

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00015B85 File Offset: 0x00013D85
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00015B8D File Offset: 0x00013D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameData WolfBroGameData
		{
			get
			{
				return this.wolfBroGameData_;
			}
			set
			{
				this.wolfBroGameData_ = value;
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00015B96 File Offset: 0x00013D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArchiveWolfBroGameScRsp);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00015BA4 File Offset: 0x00013DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArchiveWolfBroGameScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.WolfBroGameData, other.WolfBroGameData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00015BF4 File Offset: 0x00013DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.wolfBroGameData_ != null)
			{
				num ^= this.WolfBroGameData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00015C49 File Offset: 0x00013E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00015C51 File Offset: 0x00013E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00015C5C File Offset: 0x00013E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.wolfBroGameData_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.WolfBroGameData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00015CB8 File Offset: 0x00013EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.wolfBroGameData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WolfBroGameData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00015D10 File Offset: 0x00013F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArchiveWolfBroGameScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.wolfBroGameData_ != null)
			{
				if (this.wolfBroGameData_ == null)
				{
					this.WolfBroGameData = new WolfBroGameData();
				}
				this.WolfBroGameData.MergeFrom(other.WolfBroGameData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00015D78 File Offset: 0x00013F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00015D84 File Offset: 0x00013F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.wolfBroGameData_ == null)
						{
							this.WolfBroGameData = new WolfBroGameData();
						}
						input.ReadMessage(this.WolfBroGameData);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040002DE RID: 734
		private static readonly MessageParser<ArchiveWolfBroGameScRsp> _parser = new MessageParser<ArchiveWolfBroGameScRsp>(() => new ArchiveWolfBroGameScRsp());

		// Token: 0x040002DF RID: 735
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002E0 RID: 736
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040002E1 RID: 737
		private uint retcode_;

		// Token: 0x040002E2 RID: 738
		public const int WolfBroGameDataFieldNumber = 5;

		// Token: 0x040002E3 RID: 739
		private WolfBroGameData wolfBroGameData_;
	}
}
