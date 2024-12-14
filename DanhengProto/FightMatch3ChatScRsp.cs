using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000545 RID: 1349
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMatch3ChatScRsp : IMessage<FightMatch3ChatScRsp>, IMessage, IEquatable<FightMatch3ChatScRsp>, IDeepCloneable<FightMatch3ChatScRsp>, IBufferMessage
	{
		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06003C1C RID: 15388 RVA: 0x000A4D98 File Offset: 0x000A2F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMatch3ChatScRsp> Parser
		{
			get
			{
				return FightMatch3ChatScRsp._parser;
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06003C1D RID: 15389 RVA: 0x000A4D9F File Offset: 0x000A2F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightMatch3ChatScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x000A4DB1 File Offset: 0x000A2FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightMatch3ChatScRsp.Descriptor;
			}
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x000A4DB8 File Offset: 0x000A2FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3ChatScRsp()
		{
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x000A4DC0 File Offset: 0x000A2FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3ChatScRsp(FightMatch3ChatScRsp other) : this()
		{
			this.nBPDNFMOLGO_ = other.nBPDNFMOLGO_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x000A4DF1 File Offset: 0x000A2FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3ChatScRsp Clone()
		{
			return new FightMatch3ChatScRsp(this);
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06003C22 RID: 15394 RVA: 0x000A4DF9 File Offset: 0x000A2FF9
		// (set) Token: 0x06003C23 RID: 15395 RVA: 0x000A4E01 File Offset: 0x000A3001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NBPDNFMOLGO
		{
			get
			{
				return this.nBPDNFMOLGO_;
			}
			set
			{
				this.nBPDNFMOLGO_ = value;
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x000A4E0A File Offset: 0x000A300A
		// (set) Token: 0x06003C25 RID: 15397 RVA: 0x000A4E12 File Offset: 0x000A3012
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

		// Token: 0x06003C26 RID: 15398 RVA: 0x000A4E1B File Offset: 0x000A301B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightMatch3ChatScRsp);
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x000A4E29 File Offset: 0x000A3029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightMatch3ChatScRsp other)
		{
			return other != null && (other == this || (this.NBPDNFMOLGO == other.NBPDNFMOLGO && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x000A4E68 File Offset: 0x000A3068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NBPDNFMOLGO != 0U)
			{
				num ^= this.NBPDNFMOLGO.GetHashCode();
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

		// Token: 0x06003C29 RID: 15401 RVA: 0x000A4EC0 File Offset: 0x000A30C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x000A4EC8 File Offset: 0x000A30C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x000A4ED4 File Offset: 0x000A30D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NBPDNFMOLGO != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.NBPDNFMOLGO);
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

		// Token: 0x06003C2C RID: 15404 RVA: 0x000A4F30 File Offset: 0x000A3130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NBPDNFMOLGO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NBPDNFMOLGO);
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

		// Token: 0x06003C2D RID: 15405 RVA: 0x000A4F88 File Offset: 0x000A3188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightMatch3ChatScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NBPDNFMOLGO != 0U)
			{
				this.NBPDNFMOLGO = other.NBPDNFMOLGO;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x000A4FD8 File Offset: 0x000A31D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x000A4FE4 File Offset: 0x000A31E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 96U)
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
					this.NBPDNFMOLGO = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001825 RID: 6181
		private static readonly MessageParser<FightMatch3ChatScRsp> _parser = new MessageParser<FightMatch3ChatScRsp>(() => new FightMatch3ChatScRsp());

		// Token: 0x04001826 RID: 6182
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001827 RID: 6183
		public const int NBPDNFMOLGOFieldNumber = 6;

		// Token: 0x04001828 RID: 6184
		private uint nBPDNFMOLGO_;

		// Token: 0x04001829 RID: 6185
		public const int RetcodeFieldNumber = 12;

		// Token: 0x0400182A RID: 6186
		private uint retcode_;
	}
}
