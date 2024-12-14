using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001075 RID: 4213
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneGroupState : IMessage<SceneGroupState>, IMessage, IEquatable<SceneGroupState>, IDeepCloneable<SceneGroupState>, IBufferMessage
	{
		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0600BB91 RID: 48017 RVA: 0x001F87C8 File Offset: 0x001F69C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneGroupState> Parser
		{
			get
			{
				return SceneGroupState._parser;
			}
		}

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0600BB92 RID: 48018 RVA: 0x001F87CF File Offset: 0x001F69CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneGroupStateReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x0600BB93 RID: 48019 RVA: 0x001F87E1 File Offset: 0x001F69E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGroupState.Descriptor;
			}
		}

		// Token: 0x0600BB94 RID: 48020 RVA: 0x001F87E8 File Offset: 0x001F69E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupState()
		{
		}

		// Token: 0x0600BB95 RID: 48021 RVA: 0x001F87F0 File Offset: 0x001F69F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupState(SceneGroupState other) : this()
		{
			this.state_ = other.state_;
			this.groupId_ = other.groupId_;
			this.isDefault_ = other.isDefault_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB96 RID: 48022 RVA: 0x001F882D File Offset: 0x001F6A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupState Clone()
		{
			return new SceneGroupState(this);
		}

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x0600BB97 RID: 48023 RVA: 0x001F8835 File Offset: 0x001F6A35
		// (set) Token: 0x0600BB98 RID: 48024 RVA: 0x001F883D File Offset: 0x001F6A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0600BB99 RID: 48025 RVA: 0x001F8846 File Offset: 0x001F6A46
		// (set) Token: 0x0600BB9A RID: 48026 RVA: 0x001F884E File Offset: 0x001F6A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0600BB9B RID: 48027 RVA: 0x001F8857 File Offset: 0x001F6A57
		// (set) Token: 0x0600BB9C RID: 48028 RVA: 0x001F885F File Offset: 0x001F6A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDefault
		{
			get
			{
				return this.isDefault_;
			}
			set
			{
				this.isDefault_ = value;
			}
		}

		// Token: 0x0600BB9D RID: 48029 RVA: 0x001F8868 File Offset: 0x001F6A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGroupState);
		}

		// Token: 0x0600BB9E RID: 48030 RVA: 0x001F8878 File Offset: 0x001F6A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGroupState other)
		{
			return other != null && (other == this || (this.State == other.State && this.GroupId == other.GroupId && this.IsDefault == other.IsDefault && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB9F RID: 48031 RVA: 0x001F88D4 File Offset: 0x001F6AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.State != 0U)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.IsDefault)
			{
				num ^= this.IsDefault.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BBA0 RID: 48032 RVA: 0x001F8945 File Offset: 0x001F6B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BBA1 RID: 48033 RVA: 0x001F894D File Offset: 0x001F6B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBA2 RID: 48034 RVA: 0x001F8958 File Offset: 0x001F6B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.State);
			}
			if (this.IsDefault)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsDefault);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BBA3 RID: 48035 RVA: 0x001F89D0 File Offset: 0x001F6BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.State != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.State);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.IsDefault)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BBA4 RID: 48036 RVA: 0x001F8A34 File Offset: 0x001F6C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGroupState other)
		{
			if (other == null)
			{
				return;
			}
			if (other.State != 0U)
			{
				this.State = other.State;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.IsDefault)
			{
				this.IsDefault = other.IsDefault;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BBA5 RID: 48037 RVA: 0x001F8A98 File Offset: 0x001F6C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBA6 RID: 48038 RVA: 0x001F8AA4 File Offset: 0x001F6CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 48U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GroupId = input.ReadUInt32();
						}
					}
					else
					{
						this.IsDefault = input.ReadBool();
					}
				}
				else
				{
					this.State = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004C10 RID: 19472
		private static readonly MessageParser<SceneGroupState> _parser = new MessageParser<SceneGroupState>(() => new SceneGroupState());

		// Token: 0x04004C11 RID: 19473
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C12 RID: 19474
		public const int StateFieldNumber = 5;

		// Token: 0x04004C13 RID: 19475
		private uint state_;

		// Token: 0x04004C14 RID: 19476
		public const int GroupIdFieldNumber = 7;

		// Token: 0x04004C15 RID: 19477
		private uint groupId_;

		// Token: 0x04004C16 RID: 19478
		public const int IsDefaultFieldNumber = 6;

		// Token: 0x04004C17 RID: 19479
		private bool isDefault_;
	}
}
