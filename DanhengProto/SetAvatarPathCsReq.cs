using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010D1 RID: 4305
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetAvatarPathCsReq : IMessage<SetAvatarPathCsReq>, IMessage, IEquatable<SetAvatarPathCsReq>, IDeepCloneable<SetAvatarPathCsReq>, IBufferMessage
	{
		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x0600BFF9 RID: 49145 RVA: 0x00204C45 File Offset: 0x00202E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetAvatarPathCsReq> Parser
		{
			get
			{
				return SetAvatarPathCsReq._parser;
			}
		}

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x0600BFFA RID: 49146 RVA: 0x00204C4C File Offset: 0x00202E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetAvatarPathCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0600BFFB RID: 49147 RVA: 0x00204C5E File Offset: 0x00202E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAvatarPathCsReq.Descriptor;
			}
		}

		// Token: 0x0600BFFC RID: 49148 RVA: 0x00204C65 File Offset: 0x00202E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAvatarPathCsReq()
		{
		}

		// Token: 0x0600BFFD RID: 49149 RVA: 0x00204C6D File Offset: 0x00202E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAvatarPathCsReq(SetAvatarPathCsReq other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFFE RID: 49150 RVA: 0x00204C92 File Offset: 0x00202E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAvatarPathCsReq Clone()
		{
			return new SetAvatarPathCsReq(this);
		}

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0600BFFF RID: 49151 RVA: 0x00204C9A File Offset: 0x00202E9A
		// (set) Token: 0x0600C000 RID: 49152 RVA: 0x00204CA2 File Offset: 0x00202EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiPathAvatarType AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x0600C001 RID: 49153 RVA: 0x00204CAB File Offset: 0x00202EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAvatarPathCsReq);
		}

		// Token: 0x0600C002 RID: 49154 RVA: 0x00204CB9 File Offset: 0x00202EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetAvatarPathCsReq other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C003 RID: 49155 RVA: 0x00204CE8 File Offset: 0x00202EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C004 RID: 49156 RVA: 0x00204D2D File Offset: 0x00202F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C005 RID: 49157 RVA: 0x00204D35 File Offset: 0x00202F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C006 RID: 49158 RVA: 0x00204D3E File Offset: 0x00202F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C007 RID: 49159 RVA: 0x00204D70 File Offset: 0x00202F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C008 RID: 49160 RVA: 0x00204DAE File Offset: 0x00202FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetAvatarPathCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != MultiPathAvatarType.None)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C009 RID: 49161 RVA: 0x00204DDF File Offset: 0x00202FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C00A RID: 49162 RVA: 0x00204DE8 File Offset: 0x00202FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AvatarId = (MultiPathAvatarType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004DE6 RID: 19942
		private static readonly MessageParser<SetAvatarPathCsReq> _parser = new MessageParser<SetAvatarPathCsReq>(() => new SetAvatarPathCsReq());

		// Token: 0x04004DE7 RID: 19943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DE8 RID: 19944
		public const int AvatarIdFieldNumber = 1;

		// Token: 0x04004DE9 RID: 19945
		private MultiPathAvatarType avatarId_;
	}
}
