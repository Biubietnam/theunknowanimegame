using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200106F RID: 4207
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneEntityTeleportScRsp : IMessage<SceneEntityTeleportScRsp>, IMessage, IEquatable<SceneEntityTeleportScRsp>, IDeepCloneable<SceneEntityTeleportScRsp>, IBufferMessage
	{
		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x0600BB62 RID: 47970 RVA: 0x001F809F File Offset: 0x001F629F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneEntityTeleportScRsp> Parser
		{
			get
			{
				return SceneEntityTeleportScRsp._parser;
			}
		}

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x0600BB63 RID: 47971 RVA: 0x001F80A6 File Offset: 0x001F62A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneEntityTeleportScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x0600BB64 RID: 47972 RVA: 0x001F80B8 File Offset: 0x001F62B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneEntityTeleportScRsp.Descriptor;
			}
		}

		// Token: 0x0600BB65 RID: 47973 RVA: 0x001F80BF File Offset: 0x001F62BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityTeleportScRsp()
		{
		}

		// Token: 0x0600BB66 RID: 47974 RVA: 0x001F80C8 File Offset: 0x001F62C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityTeleportScRsp(SceneEntityTeleportScRsp other) : this()
		{
			this.clientPosVersion_ = other.clientPosVersion_;
			this.entityMotion_ = ((other.entityMotion_ != null) ? other.entityMotion_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB67 RID: 47975 RVA: 0x001F8120 File Offset: 0x001F6320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityTeleportScRsp Clone()
		{
			return new SceneEntityTeleportScRsp(this);
		}

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x0600BB68 RID: 47976 RVA: 0x001F8128 File Offset: 0x001F6328
		// (set) Token: 0x0600BB69 RID: 47977 RVA: 0x001F8130 File Offset: 0x001F6330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ClientPosVersion
		{
			get
			{
				return this.clientPosVersion_;
			}
			set
			{
				this.clientPosVersion_ = value;
			}
		}

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x0600BB6A RID: 47978 RVA: 0x001F8139 File Offset: 0x001F6339
		// (set) Token: 0x0600BB6B RID: 47979 RVA: 0x001F8141 File Offset: 0x001F6341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMotion EntityMotion
		{
			get
			{
				return this.entityMotion_;
			}
			set
			{
				this.entityMotion_ = value;
			}
		}

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x0600BB6C RID: 47980 RVA: 0x001F814A File Offset: 0x001F634A
		// (set) Token: 0x0600BB6D RID: 47981 RVA: 0x001F8152 File Offset: 0x001F6352
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

		// Token: 0x0600BB6E RID: 47982 RVA: 0x001F815B File Offset: 0x001F635B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneEntityTeleportScRsp);
		}

		// Token: 0x0600BB6F RID: 47983 RVA: 0x001F816C File Offset: 0x001F636C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneEntityTeleportScRsp other)
		{
			return other != null && (other == this || (this.ClientPosVersion == other.ClientPosVersion && object.Equals(this.EntityMotion, other.EntityMotion) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB70 RID: 47984 RVA: 0x001F81CC File Offset: 0x001F63CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ClientPosVersion != 0U)
			{
				num ^= this.ClientPosVersion.GetHashCode();
			}
			if (this.entityMotion_ != null)
			{
				num ^= this.EntityMotion.GetHashCode();
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

		// Token: 0x0600BB71 RID: 47985 RVA: 0x001F823A File Offset: 0x001F643A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BB72 RID: 47986 RVA: 0x001F8242 File Offset: 0x001F6442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB73 RID: 47987 RVA: 0x001F824C File Offset: 0x001F644C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientPosVersion != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ClientPosVersion);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.entityMotion_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.EntityMotion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB74 RID: 47988 RVA: 0x001F82C4 File Offset: 0x001F64C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ClientPosVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClientPosVersion);
			}
			if (this.entityMotion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityMotion);
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

		// Token: 0x0600BB75 RID: 47989 RVA: 0x001F8334 File Offset: 0x001F6534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneEntityTeleportScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ClientPosVersion != 0U)
			{
				this.ClientPosVersion = other.ClientPosVersion;
			}
			if (other.entityMotion_ != null)
			{
				if (this.entityMotion_ == null)
				{
					this.EntityMotion = new EntityMotion();
				}
				this.EntityMotion.MergeFrom(other.EntityMotion);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB76 RID: 47990 RVA: 0x001F83B0 File Offset: 0x001F65B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB77 RID: 47991 RVA: 0x001F83BC File Offset: 0x001F65BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 64U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.entityMotion_ == null)
							{
								this.EntityMotion = new EntityMotion();
							}
							input.ReadMessage(this.EntityMotion);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.ClientPosVersion = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004BFC RID: 19452
		private static readonly MessageParser<SceneEntityTeleportScRsp> _parser = new MessageParser<SceneEntityTeleportScRsp>(() => new SceneEntityTeleportScRsp());

		// Token: 0x04004BFD RID: 19453
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BFE RID: 19454
		public const int ClientPosVersionFieldNumber = 6;

		// Token: 0x04004BFF RID: 19455
		private uint clientPosVersion_;

		// Token: 0x04004C00 RID: 19456
		public const int EntityMotionFieldNumber = 13;

		// Token: 0x04004C01 RID: 19457
		private EntityMotion entityMotion_;

		// Token: 0x04004C02 RID: 19458
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04004C03 RID: 19459
		private uint retcode_;
	}
}
