using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CBF RID: 3263
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerHeartBeatScRsp : IMessage<PlayerHeartBeatScRsp>, IMessage, IEquatable<PlayerHeartBeatScRsp>, IDeepCloneable<PlayerHeartBeatScRsp>, IBufferMessage
	{
		// Token: 0x170028DB RID: 10459
		// (get) Token: 0x06009147 RID: 37191 RVA: 0x001808F7 File Offset: 0x0017EAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerHeartBeatScRsp> Parser
		{
			get
			{
				return PlayerHeartBeatScRsp._parser;
			}
		}

		// Token: 0x170028DC RID: 10460
		// (get) Token: 0x06009148 RID: 37192 RVA: 0x001808FE File Offset: 0x0017EAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerHeartBeatScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170028DD RID: 10461
		// (get) Token: 0x06009149 RID: 37193 RVA: 0x00180910 File Offset: 0x0017EB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerHeartBeatScRsp.Descriptor;
			}
		}

		// Token: 0x0600914A RID: 37194 RVA: 0x00180917 File Offset: 0x0017EB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeartBeatScRsp()
		{
		}

		// Token: 0x0600914B RID: 37195 RVA: 0x00180920 File Offset: 0x0017EB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeartBeatScRsp(PlayerHeartBeatScRsp other) : this()
		{
			this.serverTimeMs_ = other.serverTimeMs_;
			this.retcode_ = other.retcode_;
			this.downloadData_ = ((other.downloadData_ != null) ? other.downloadData_.Clone() : null);
			this.clientTimeMs_ = other.clientTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600914C RID: 37196 RVA: 0x00180984 File Offset: 0x0017EB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeartBeatScRsp Clone()
		{
			return new PlayerHeartBeatScRsp(this);
		}

		// Token: 0x170028DE RID: 10462
		// (get) Token: 0x0600914D RID: 37197 RVA: 0x0018098C File Offset: 0x0017EB8C
		// (set) Token: 0x0600914E RID: 37198 RVA: 0x00180994 File Offset: 0x0017EB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong ServerTimeMs
		{
			get
			{
				return this.serverTimeMs_;
			}
			set
			{
				this.serverTimeMs_ = value;
			}
		}

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x0600914F RID: 37199 RVA: 0x0018099D File Offset: 0x0017EB9D
		// (set) Token: 0x06009150 RID: 37200 RVA: 0x001809A5 File Offset: 0x0017EBA5
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

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x06009151 RID: 37201 RVA: 0x001809AE File Offset: 0x0017EBAE
		// (set) Token: 0x06009152 RID: 37202 RVA: 0x001809B6 File Offset: 0x0017EBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDownloadData DownloadData
		{
			get
			{
				return this.downloadData_;
			}
			set
			{
				this.downloadData_ = value;
			}
		}

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x06009153 RID: 37203 RVA: 0x001809BF File Offset: 0x0017EBBF
		// (set) Token: 0x06009154 RID: 37204 RVA: 0x001809C7 File Offset: 0x0017EBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong ClientTimeMs
		{
			get
			{
				return this.clientTimeMs_;
			}
			set
			{
				this.clientTimeMs_ = value;
			}
		}

		// Token: 0x06009155 RID: 37205 RVA: 0x001809D0 File Offset: 0x0017EBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerHeartBeatScRsp);
		}

		// Token: 0x06009156 RID: 37206 RVA: 0x001809E0 File Offset: 0x0017EBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerHeartBeatScRsp other)
		{
			return other != null && (other == this || (this.ServerTimeMs == other.ServerTimeMs && this.Retcode == other.Retcode && object.Equals(this.DownloadData, other.DownloadData) && this.ClientTimeMs == other.ClientTimeMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009157 RID: 37207 RVA: 0x00180A50 File Offset: 0x0017EC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ServerTimeMs != 0UL)
			{
				num ^= this.ServerTimeMs.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.downloadData_ != null)
			{
				num ^= this.DownloadData.GetHashCode();
			}
			if (this.ClientTimeMs != 0UL)
			{
				num ^= this.ClientTimeMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009158 RID: 37208 RVA: 0x00180AD7 File Offset: 0x0017ECD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009159 RID: 37209 RVA: 0x00180ADF File Offset: 0x0017ECDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600915A RID: 37210 RVA: 0x00180AE8 File Offset: 0x0017ECE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientTimeMs != 0UL)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ClientTimeMs);
			}
			if (this.ServerTimeMs != 0UL)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.ServerTimeMs);
			}
			if (this.downloadData_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.DownloadData);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600915B RID: 37211 RVA: 0x00180B78 File Offset: 0x0017ED78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ServerTimeMs != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ServerTimeMs);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.downloadData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DownloadData);
			}
			if (this.ClientTimeMs != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClientTimeMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600915C RID: 37212 RVA: 0x00180C00 File Offset: 0x0017EE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerHeartBeatScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ServerTimeMs != 0UL)
			{
				this.ServerTimeMs = other.ServerTimeMs;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.downloadData_ != null)
			{
				if (this.downloadData_ == null)
				{
					this.DownloadData = new ClientDownloadData();
				}
				this.DownloadData.MergeFrom(other.DownloadData);
			}
			if (other.ClientTimeMs != 0UL)
			{
				this.ClientTimeMs = other.ClientTimeMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600915D RID: 37213 RVA: 0x00180C90 File Offset: 0x0017EE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600915E RID: 37214 RVA: 0x00180C9C File Offset: 0x0017EE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.ClientTimeMs = input.ReadUInt64();
						continue;
					}
					if (num == 32U)
					{
						this.ServerTimeMs = input.ReadUInt64();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						if (this.downloadData_ == null)
						{
							this.DownloadData = new ClientDownloadData();
						}
						input.ReadMessage(this.DownloadData);
						continue;
					}
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040037F7 RID: 14327
		private static readonly MessageParser<PlayerHeartBeatScRsp> _parser = new MessageParser<PlayerHeartBeatScRsp>(() => new PlayerHeartBeatScRsp());

		// Token: 0x040037F8 RID: 14328
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037F9 RID: 14329
		public const int ServerTimeMsFieldNumber = 4;

		// Token: 0x040037FA RID: 14330
		private ulong serverTimeMs_;

		// Token: 0x040037FB RID: 14331
		public const int RetcodeFieldNumber = 12;

		// Token: 0x040037FC RID: 14332
		private uint retcode_;

		// Token: 0x040037FD RID: 14333
		public const int DownloadDataFieldNumber = 7;

		// Token: 0x040037FE RID: 14334
		private ClientDownloadData downloadData_;

		// Token: 0x040037FF RID: 14335
		public const int ClientTimeMsFieldNumber = 1;

		// Token: 0x04003800 RID: 14336
		private ulong clientTimeMs_;
	}
}
