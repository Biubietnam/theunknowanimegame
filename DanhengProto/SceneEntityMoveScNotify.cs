using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001067 RID: 4199
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneEntityMoveScNotify : IMessage<SceneEntityMoveScNotify>, IMessage, IEquatable<SceneEntityMoveScNotify>, IDeepCloneable<SceneEntityMoveScNotify>, IBufferMessage
	{
		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x0600BAF9 RID: 47865 RVA: 0x001F6E5B File Offset: 0x001F505B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneEntityMoveScNotify> Parser
		{
			get
			{
				return SceneEntityMoveScNotify._parser;
			}
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x0600BAFA RID: 47866 RVA: 0x001F6E62 File Offset: 0x001F5062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneEntityMoveScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x0600BAFB RID: 47867 RVA: 0x001F6E74 File Offset: 0x001F5074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneEntityMoveScNotify.Descriptor;
			}
		}

		// Token: 0x0600BAFC RID: 47868 RVA: 0x001F6E7B File Offset: 0x001F507B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityMoveScNotify()
		{
		}

		// Token: 0x0600BAFD RID: 47869 RVA: 0x001F6E84 File Offset: 0x001F5084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityMoveScNotify(SceneEntityMoveScNotify other) : this()
		{
			this.entryId_ = other.entryId_;
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this.entityId_ = other.entityId_;
			this.clientPosVersion_ = other.clientPosVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BAFE RID: 47870 RVA: 0x001F6EE8 File Offset: 0x001F50E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityMoveScNotify Clone()
		{
			return new SceneEntityMoveScNotify(this);
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x0600BAFF RID: 47871 RVA: 0x001F6EF0 File Offset: 0x001F50F0
		// (set) Token: 0x0600BB00 RID: 47872 RVA: 0x001F6EF8 File Offset: 0x001F50F8
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

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x0600BB01 RID: 47873 RVA: 0x001F6F01 File Offset: 0x001F5101
		// (set) Token: 0x0600BB02 RID: 47874 RVA: 0x001F6F09 File Offset: 0x001F5109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo Motion
		{
			get
			{
				return this.motion_;
			}
			set
			{
				this.motion_ = value;
			}
		}

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x0600BB03 RID: 47875 RVA: 0x001F6F12 File Offset: 0x001F5112
		// (set) Token: 0x0600BB04 RID: 47876 RVA: 0x001F6F1A File Offset: 0x001F511A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x0600BB05 RID: 47877 RVA: 0x001F6F23 File Offset: 0x001F5123
		// (set) Token: 0x0600BB06 RID: 47878 RVA: 0x001F6F2B File Offset: 0x001F512B
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

		// Token: 0x0600BB07 RID: 47879 RVA: 0x001F6F34 File Offset: 0x001F5134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneEntityMoveScNotify);
		}

		// Token: 0x0600BB08 RID: 47880 RVA: 0x001F6F44 File Offset: 0x001F5144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneEntityMoveScNotify other)
		{
			return other != null && (other == this || (this.EntryId == other.EntryId && object.Equals(this.Motion, other.Motion) && this.EntityId == other.EntityId && this.ClientPosVersion == other.ClientPosVersion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB09 RID: 47881 RVA: 0x001F6FB4 File Offset: 0x001F51B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntryId != 0U)
			{
				num ^= this.EntryId.GetHashCode();
			}
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this.EntityId != 0U)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ClientPosVersion != 0U)
			{
				num ^= this.ClientPosVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BB0A RID: 47882 RVA: 0x001F703B File Offset: 0x001F523B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BB0B RID: 47883 RVA: 0x001F7043 File Offset: 0x001F5243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB0C RID: 47884 RVA: 0x001F704C File Offset: 0x001F524C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.EntityId);
			}
			if (this.EntryId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.EntryId);
			}
			if (this.ClientPosVersion != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ClientPosVersion);
			}
			if (this.motion_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Motion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB0D RID: 47885 RVA: 0x001F70DC File Offset: 0x001F52DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntryId);
			}
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this.EntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntityId);
			}
			if (this.ClientPosVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClientPosVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB0E RID: 47886 RVA: 0x001F7164 File Offset: 0x001F5364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneEntityMoveScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntryId != 0U)
			{
				this.EntryId = other.EntryId;
			}
			if (other.motion_ != null)
			{
				if (this.motion_ == null)
				{
					this.Motion = new MotionInfo();
				}
				this.Motion.MergeFrom(other.Motion);
			}
			if (other.EntityId != 0U)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ClientPosVersion != 0U)
			{
				this.ClientPosVersion = other.ClientPosVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB0F RID: 47887 RVA: 0x001F71F4 File Offset: 0x001F53F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB10 RID: 47888 RVA: 0x001F7200 File Offset: 0x001F5400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.EntityId = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.EntryId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.ClientPosVersion = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.motion_ == null)
						{
							this.Motion = new MotionInfo();
						}
						input.ReadMessage(this.Motion);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004BD8 RID: 19416
		private static readonly MessageParser<SceneEntityMoveScNotify> _parser = new MessageParser<SceneEntityMoveScNotify>(() => new SceneEntityMoveScNotify());

		// Token: 0x04004BD9 RID: 19417
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BDA RID: 19418
		public const int EntryIdFieldNumber = 2;

		// Token: 0x04004BDB RID: 19419
		private uint entryId_;

		// Token: 0x04004BDC RID: 19420
		public const int MotionFieldNumber = 14;

		// Token: 0x04004BDD RID: 19421
		private MotionInfo motion_;

		// Token: 0x04004BDE RID: 19422
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04004BDF RID: 19423
		private uint entityId_;

		// Token: 0x04004BE0 RID: 19424
		public const int ClientPosVersionFieldNumber = 4;

		// Token: 0x04004BE1 RID: 19425
		private uint clientPosVersion_;
	}
}
