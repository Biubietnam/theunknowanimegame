using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001071 RID: 4209
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneGroupRefreshScNotify : IMessage<SceneGroupRefreshScNotify>, IMessage, IEquatable<SceneGroupRefreshScNotify>, IDeepCloneable<SceneGroupRefreshScNotify>, IBufferMessage
	{
		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x0600BB7B RID: 47995 RVA: 0x001F84D1 File Offset: 0x001F66D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneGroupRefreshScNotify> Parser
		{
			get
			{
				return SceneGroupRefreshScNotify._parser;
			}
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0600BB7C RID: 47996 RVA: 0x001F84D8 File Offset: 0x001F66D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneGroupRefreshScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0600BB7D RID: 47997 RVA: 0x001F84EA File Offset: 0x001F66EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGroupRefreshScNotify.Descriptor;
			}
		}

		// Token: 0x0600BB7E RID: 47998 RVA: 0x001F84F1 File Offset: 0x001F66F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupRefreshScNotify()
		{
		}

		// Token: 0x0600BB7F RID: 47999 RVA: 0x001F8504 File Offset: 0x001F6704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupRefreshScNotify(SceneGroupRefreshScNotify other) : this()
		{
			this.groupRefreshList_ = other.groupRefreshList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB80 RID: 48000 RVA: 0x001F852E File Offset: 0x001F672E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGroupRefreshScNotify Clone()
		{
			return new SceneGroupRefreshScNotify(this);
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0600BB81 RID: 48001 RVA: 0x001F8536 File Offset: 0x001F6736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GroupRefreshInfo> GroupRefreshList
		{
			get
			{
				return this.groupRefreshList_;
			}
		}

		// Token: 0x0600BB82 RID: 48002 RVA: 0x001F853E File Offset: 0x001F673E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGroupRefreshScNotify);
		}

		// Token: 0x0600BB83 RID: 48003 RVA: 0x001F854C File Offset: 0x001F674C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGroupRefreshScNotify other)
		{
			return other != null && (other == this || (this.groupRefreshList_.Equals(other.groupRefreshList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB84 RID: 48004 RVA: 0x001F8580 File Offset: 0x001F6780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.groupRefreshList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BB85 RID: 48005 RVA: 0x001F85B4 File Offset: 0x001F67B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BB86 RID: 48006 RVA: 0x001F85BC File Offset: 0x001F67BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB87 RID: 48007 RVA: 0x001F85C5 File Offset: 0x001F67C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.groupRefreshList_.WriteTo(ref output, SceneGroupRefreshScNotify._repeated_groupRefreshList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB88 RID: 48008 RVA: 0x001F85EC File Offset: 0x001F67EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.groupRefreshList_.CalculateSize(SceneGroupRefreshScNotify._repeated_groupRefreshList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB89 RID: 48009 RVA: 0x001F8625 File Offset: 0x001F6825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGroupRefreshScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.groupRefreshList_.Add(other.groupRefreshList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB8A RID: 48010 RVA: 0x001F8653 File Offset: 0x001F6853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB8B RID: 48011 RVA: 0x001F865C File Offset: 0x001F685C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.groupRefreshList_.AddEntriesFrom(ref input, SceneGroupRefreshScNotify._repeated_groupRefreshList_codec);
				}
			}
		}

		// Token: 0x04004C05 RID: 19461
		private static readonly MessageParser<SceneGroupRefreshScNotify> _parser = new MessageParser<SceneGroupRefreshScNotify>(() => new SceneGroupRefreshScNotify());

		// Token: 0x04004C06 RID: 19462
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C07 RID: 19463
		public const int GroupRefreshListFieldNumber = 8;

		// Token: 0x04004C08 RID: 19464
		private static readonly FieldCodec<GroupRefreshInfo> _repeated_groupRefreshList_codec = FieldCodec.ForMessage<GroupRefreshInfo>(66U, GroupRefreshInfo.Parser);

		// Token: 0x04004C09 RID: 19465
		private readonly RepeatedField<GroupRefreshInfo> groupRefreshList_ = new RepeatedField<GroupRefreshInfo>();
	}
}
