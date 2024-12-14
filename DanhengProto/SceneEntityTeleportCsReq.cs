using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200106D RID: 4205
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneEntityTeleportCsReq : IMessage<SceneEntityTeleportCsReq>, IMessage, IEquatable<SceneEntityTeleportCsReq>, IDeepCloneable<SceneEntityTeleportCsReq>, IBufferMessage
	{
		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x0600BB4B RID: 47947 RVA: 0x001F7CE5 File Offset: 0x001F5EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneEntityTeleportCsReq> Parser
		{
			get
			{
				return SceneEntityTeleportCsReq._parser;
			}
		}

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x0600BB4C RID: 47948 RVA: 0x001F7CEC File Offset: 0x001F5EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneEntityTeleportCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x0600BB4D RID: 47949 RVA: 0x001F7CFE File Offset: 0x001F5EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneEntityTeleportCsReq.Descriptor;
			}
		}

		// Token: 0x0600BB4E RID: 47950 RVA: 0x001F7D05 File Offset: 0x001F5F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityTeleportCsReq()
		{
		}

		// Token: 0x0600BB4F RID: 47951 RVA: 0x001F7D10 File Offset: 0x001F5F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityTeleportCsReq(SceneEntityTeleportCsReq other) : this()
		{
			this.entryId_ = other.entryId_;
			this.entityMotion_ = ((other.entityMotion_ != null) ? other.entityMotion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB50 RID: 47952 RVA: 0x001F7D5C File Offset: 0x001F5F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityTeleportCsReq Clone()
		{
			return new SceneEntityTeleportCsReq(this);
		}

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x0600BB51 RID: 47953 RVA: 0x001F7D64 File Offset: 0x001F5F64
		// (set) Token: 0x0600BB52 RID: 47954 RVA: 0x001F7D6C File Offset: 0x001F5F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntryId
		{
			get
			{
				return this.entryId_;
			}
			set
			{
				this.entryId_ = value;
			}
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x0600BB53 RID: 47955 RVA: 0x001F7D75 File Offset: 0x001F5F75
		// (set) Token: 0x0600BB54 RID: 47956 RVA: 0x001F7D7D File Offset: 0x001F5F7D
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

		// Token: 0x0600BB55 RID: 47957 RVA: 0x001F7D86 File Offset: 0x001F5F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneEntityTeleportCsReq);
		}

		// Token: 0x0600BB56 RID: 47958 RVA: 0x001F7D94 File Offset: 0x001F5F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneEntityTeleportCsReq other)
		{
			return other != null && (other == this || (this.EntryId == other.EntryId && object.Equals(this.EntityMotion, other.EntityMotion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB57 RID: 47959 RVA: 0x001F7DE4 File Offset: 0x001F5FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntryId != 0U)
			{
				num ^= this.EntryId.GetHashCode();
			}
			if (this.entityMotion_ != null)
			{
				num ^= this.EntityMotion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BB58 RID: 47960 RVA: 0x001F7E39 File Offset: 0x001F6039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BB59 RID: 47961 RVA: 0x001F7E41 File Offset: 0x001F6041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB5A RID: 47962 RVA: 0x001F7E4C File Offset: 0x001F604C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityMotion_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.EntityMotion);
			}
			if (this.EntryId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.EntryId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB5B RID: 47963 RVA: 0x001F7EA8 File Offset: 0x001F60A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntryId);
			}
			if (this.entityMotion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityMotion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB5C RID: 47964 RVA: 0x001F7F00 File Offset: 0x001F6100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneEntityTeleportCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntryId != 0U)
			{
				this.EntryId = other.EntryId;
			}
			if (other.entityMotion_ != null)
			{
				if (this.entityMotion_ == null)
				{
					this.EntityMotion = new EntityMotion();
				}
				this.EntityMotion.MergeFrom(other.EntityMotion);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB5D RID: 47965 RVA: 0x001F7F68 File Offset: 0x001F6168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB5E RID: 47966 RVA: 0x001F7F74 File Offset: 0x001F6174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntryId = input.ReadUInt32();
					}
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
		}

		// Token: 0x04004BF5 RID: 19445
		private static readonly MessageParser<SceneEntityTeleportCsReq> _parser = new MessageParser<SceneEntityTeleportCsReq>(() => new SceneEntityTeleportCsReq());

		// Token: 0x04004BF6 RID: 19446
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BF7 RID: 19447
		public const int EntryIdFieldNumber = 13;

		// Token: 0x04004BF8 RID: 19448
		private uint entryId_;

		// Token: 0x04004BF9 RID: 19449
		public const int EntityMotionFieldNumber = 6;

		// Token: 0x04004BFA RID: 19450
		private EntityMotion entityMotion_;
	}
}
