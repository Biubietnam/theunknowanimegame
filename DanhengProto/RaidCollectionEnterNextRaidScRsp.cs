using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D69 RID: 3433
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RaidCollectionEnterNextRaidScRsp : IMessage<RaidCollectionEnterNextRaidScRsp>, IMessage, IEquatable<RaidCollectionEnterNextRaidScRsp>, IDeepCloneable<RaidCollectionEnterNextRaidScRsp>, IBufferMessage
	{
		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x06009963 RID: 39267 RVA: 0x001984AB File Offset: 0x001966AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RaidCollectionEnterNextRaidScRsp> Parser
		{
			get
			{
				return RaidCollectionEnterNextRaidScRsp._parser;
			}
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x06009964 RID: 39268 RVA: 0x001984B2 File Offset: 0x001966B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RaidCollectionEnterNextRaidScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x06009965 RID: 39269 RVA: 0x001984C4 File Offset: 0x001966C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RaidCollectionEnterNextRaidScRsp.Descriptor;
			}
		}

		// Token: 0x06009966 RID: 39270 RVA: 0x001984CB File Offset: 0x001966CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionEnterNextRaidScRsp()
		{
		}

		// Token: 0x06009967 RID: 39271 RVA: 0x001984D4 File Offset: 0x001966D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionEnterNextRaidScRsp(RaidCollectionEnterNextRaidScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009968 RID: 39272 RVA: 0x00198520 File Offset: 0x00196720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionEnterNextRaidScRsp Clone()
		{
			return new RaidCollectionEnterNextRaidScRsp(this);
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x06009969 RID: 39273 RVA: 0x00198528 File Offset: 0x00196728
		// (set) Token: 0x0600996A RID: 39274 RVA: 0x00198530 File Offset: 0x00196730
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

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x0600996B RID: 39275 RVA: 0x00198539 File Offset: 0x00196739
		// (set) Token: 0x0600996C RID: 39276 RVA: 0x00198541 File Offset: 0x00196741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIIOLCPBLCF Scene
		{
			get
			{
				return this.scene_;
			}
			set
			{
				this.scene_ = value;
			}
		}

		// Token: 0x0600996D RID: 39277 RVA: 0x0019854A File Offset: 0x0019674A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RaidCollectionEnterNextRaidScRsp);
		}

		// Token: 0x0600996E RID: 39278 RVA: 0x00198558 File Offset: 0x00196758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RaidCollectionEnterNextRaidScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Scene, other.Scene) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600996F RID: 39279 RVA: 0x001985A8 File Offset: 0x001967A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009970 RID: 39280 RVA: 0x001985FD File Offset: 0x001967FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009971 RID: 39281 RVA: 0x00198605 File Offset: 0x00196805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009972 RID: 39282 RVA: 0x00198610 File Offset: 0x00196810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009973 RID: 39283 RVA: 0x0019866C File Offset: 0x0019686C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009974 RID: 39284 RVA: 0x001986C4 File Offset: 0x001968C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RaidCollectionEnterNextRaidScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new OIIOLCPBLCF();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009975 RID: 39285 RVA: 0x0019872C File Offset: 0x0019692C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009976 RID: 39286 RVA: 0x00198738 File Offset: 0x00196938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.scene_ == null)
						{
							this.Scene = new OIIOLCPBLCF();
						}
						input.ReadMessage(this.Scene);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003B8C RID: 15244
		private static readonly MessageParser<RaidCollectionEnterNextRaidScRsp> _parser = new MessageParser<RaidCollectionEnterNextRaidScRsp>(() => new RaidCollectionEnterNextRaidScRsp());

		// Token: 0x04003B8D RID: 15245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B8E RID: 15246
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04003B8F RID: 15247
		private uint retcode_;

		// Token: 0x04003B90 RID: 15248
		public const int SceneFieldNumber = 13;

		// Token: 0x04003B91 RID: 15249
		private OIIOLCPBLCF scene_;
	}
}
