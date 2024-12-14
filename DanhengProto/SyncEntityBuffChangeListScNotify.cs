using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001273 RID: 4723
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncEntityBuffChangeListScNotify : IMessage<SyncEntityBuffChangeListScNotify>, IMessage, IEquatable<SyncEntityBuffChangeListScNotify>, IDeepCloneable<SyncEntityBuffChangeListScNotify>, IBufferMessage
	{
		// Token: 0x17003B54 RID: 15188
		// (get) Token: 0x0600D2D0 RID: 53968 RVA: 0x0023324F File Offset: 0x0023144F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncEntityBuffChangeListScNotify> Parser
		{
			get
			{
				return SyncEntityBuffChangeListScNotify._parser;
			}
		}

		// Token: 0x17003B55 RID: 15189
		// (get) Token: 0x0600D2D1 RID: 53969 RVA: 0x00233256 File Offset: 0x00231456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncEntityBuffChangeListScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x0600D2D2 RID: 53970 RVA: 0x00233268 File Offset: 0x00231468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncEntityBuffChangeListScNotify.Descriptor;
			}
		}

		// Token: 0x0600D2D3 RID: 53971 RVA: 0x0023326F File Offset: 0x0023146F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncEntityBuffChangeListScNotify()
		{
		}

		// Token: 0x0600D2D4 RID: 53972 RVA: 0x00233282 File Offset: 0x00231482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncEntityBuffChangeListScNotify(SyncEntityBuffChangeListScNotify other) : this()
		{
			this.entityBuffChangeList_ = other.entityBuffChangeList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2D5 RID: 53973 RVA: 0x002332AC File Offset: 0x002314AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncEntityBuffChangeListScNotify Clone()
		{
			return new SyncEntityBuffChangeListScNotify(this);
		}

		// Token: 0x17003B57 RID: 15191
		// (get) Token: 0x0600D2D6 RID: 53974 RVA: 0x002332B4 File Offset: 0x002314B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityBuffChangeInfo> EntityBuffChangeList
		{
			get
			{
				return this.entityBuffChangeList_;
			}
		}

		// Token: 0x0600D2D7 RID: 53975 RVA: 0x002332BC File Offset: 0x002314BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncEntityBuffChangeListScNotify);
		}

		// Token: 0x0600D2D8 RID: 53976 RVA: 0x002332CA File Offset: 0x002314CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncEntityBuffChangeListScNotify other)
		{
			return other != null && (other == this || (this.entityBuffChangeList_.Equals(other.entityBuffChangeList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D2D9 RID: 53977 RVA: 0x00233300 File Offset: 0x00231500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityBuffChangeList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D2DA RID: 53978 RVA: 0x00233334 File Offset: 0x00231534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D2DB RID: 53979 RVA: 0x0023333C File Offset: 0x0023153C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2DC RID: 53980 RVA: 0x00233345 File Offset: 0x00231545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityBuffChangeList_.WriteTo(ref output, SyncEntityBuffChangeListScNotify._repeated_entityBuffChangeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D2DD RID: 53981 RVA: 0x0023336C File Offset: 0x0023156C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityBuffChangeList_.CalculateSize(SyncEntityBuffChangeListScNotify._repeated_entityBuffChangeList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D2DE RID: 53982 RVA: 0x002333A5 File Offset: 0x002315A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncEntityBuffChangeListScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityBuffChangeList_.Add(other.entityBuffChangeList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D2DF RID: 53983 RVA: 0x002333D3 File Offset: 0x002315D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2E0 RID: 53984 RVA: 0x002333DC File Offset: 0x002315DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityBuffChangeList_.AddEntriesFrom(ref input, SyncEntityBuffChangeListScNotify._repeated_entityBuffChangeList_codec);
				}
			}
		}

		// Token: 0x0400546F RID: 21615
		private static readonly MessageParser<SyncEntityBuffChangeListScNotify> _parser = new MessageParser<SyncEntityBuffChangeListScNotify>(() => new SyncEntityBuffChangeListScNotify());

		// Token: 0x04005470 RID: 21616
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005471 RID: 21617
		public const int EntityBuffChangeListFieldNumber = 7;

		// Token: 0x04005472 RID: 21618
		private static readonly FieldCodec<EntityBuffChangeInfo> _repeated_entityBuffChangeList_codec = FieldCodec.ForMessage<EntityBuffChangeInfo>(58U, EntityBuffChangeInfo.Parser);

		// Token: 0x04005473 RID: 21619
		private readonly RepeatedField<EntityBuffChangeInfo> entityBuffChangeList_ = new RepeatedField<EntityBuffChangeInfo>();
	}
}
