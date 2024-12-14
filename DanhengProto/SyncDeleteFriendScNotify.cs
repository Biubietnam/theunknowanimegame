using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001271 RID: 4721
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncDeleteFriendScNotify : IMessage<SyncDeleteFriendScNotify>, IMessage, IEquatable<SyncDeleteFriendScNotify>, IDeepCloneable<SyncDeleteFriendScNotify>, IBufferMessage
	{
		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x0600D2BB RID: 53947 RVA: 0x00232FB8 File Offset: 0x002311B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncDeleteFriendScNotify> Parser
		{
			get
			{
				return SyncDeleteFriendScNotify._parser;
			}
		}

		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x0600D2BC RID: 53948 RVA: 0x00232FBF File Offset: 0x002311BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncDeleteFriendScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x0600D2BD RID: 53949 RVA: 0x00232FD1 File Offset: 0x002311D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncDeleteFriendScNotify.Descriptor;
			}
		}

		// Token: 0x0600D2BE RID: 53950 RVA: 0x00232FD8 File Offset: 0x002311D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncDeleteFriendScNotify()
		{
		}

		// Token: 0x0600D2BF RID: 53951 RVA: 0x00232FE0 File Offset: 0x002311E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncDeleteFriendScNotify(SyncDeleteFriendScNotify other) : this()
		{
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2C0 RID: 53952 RVA: 0x00233005 File Offset: 0x00231205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncDeleteFriendScNotify Clone()
		{
			return new SyncDeleteFriendScNotify(this);
		}

		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x0600D2C1 RID: 53953 RVA: 0x0023300D File Offset: 0x0023120D
		// (set) Token: 0x0600D2C2 RID: 53954 RVA: 0x00233015 File Offset: 0x00231215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x0600D2C3 RID: 53955 RVA: 0x0023301E File Offset: 0x0023121E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncDeleteFriendScNotify);
		}

		// Token: 0x0600D2C4 RID: 53956 RVA: 0x0023302C File Offset: 0x0023122C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncDeleteFriendScNotify other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D2C5 RID: 53957 RVA: 0x0023305C File Offset: 0x0023125C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D2C6 RID: 53958 RVA: 0x0023309B File Offset: 0x0023129B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D2C7 RID: 53959 RVA: 0x002330A3 File Offset: 0x002312A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2C8 RID: 53960 RVA: 0x002330AC File Offset: 0x002312AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D2C9 RID: 53961 RVA: 0x002330E0 File Offset: 0x002312E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D2CA RID: 53962 RVA: 0x0023311E File Offset: 0x0023131E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncDeleteFriendScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D2CB RID: 53963 RVA: 0x0023314F File Offset: 0x0023134F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2CC RID: 53964 RVA: 0x00233158 File Offset: 0x00231358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400546A RID: 21610
		private static readonly MessageParser<SyncDeleteFriendScNotify> _parser = new MessageParser<SyncDeleteFriendScNotify>(() => new SyncDeleteFriendScNotify());

		// Token: 0x0400546B RID: 21611
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400546C RID: 21612
		public const int UidFieldNumber = 13;

		// Token: 0x0400546D RID: 21613
		private uint uid_;
	}
}
