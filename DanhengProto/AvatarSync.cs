using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000CB RID: 203
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AvatarSync : IMessage<AvatarSync>, IMessage, IEquatable<AvatarSync>, IDeepCloneable<AvatarSync>, IBufferMessage
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0001B284 File Offset: 0x00019484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AvatarSync> Parser
		{
			get
			{
				return AvatarSync._parser;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0001B28B File Offset: 0x0001948B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarSyncReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0001B29D File Offset: 0x0001949D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarSync.Descriptor;
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0001B2A4 File Offset: 0x000194A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarSync()
		{
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0001B2B7 File Offset: 0x000194B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarSync(AvatarSync other) : this()
		{
			this.avatarList_ = other.avatarList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0001B2E1 File Offset: 0x000194E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarSync Clone()
		{
			return new AvatarSync(this);
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0001B2E9 File Offset: 0x000194E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Avatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0001B2F1 File Offset: 0x000194F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarSync);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0001B2FF File Offset: 0x000194FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvatarSync other)
		{
			return other != null && (other == this || (this.avatarList_.Equals(other.avatarList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0001B334 File Offset: 0x00019534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0001B368 File Offset: 0x00019568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0001B370 File Offset: 0x00019570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0001B379 File Offset: 0x00019579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarList_.WriteTo(ref output, AvatarSync._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0001B3A0 File Offset: 0x000195A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarList_.CalculateSize(AvatarSync._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0001B3D9 File Offset: 0x000195D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvatarSync other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarList_.Add(other.avatarList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0001B407 File Offset: 0x00019607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0001B410 File Offset: 0x00019610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.avatarList_.AddEntriesFrom(ref input, AvatarSync._repeated_avatarList_codec);
				}
			}
		}

		// Token: 0x040003BA RID: 954
		private static readonly MessageParser<AvatarSync> _parser = new MessageParser<AvatarSync>(() => new AvatarSync());

		// Token: 0x040003BB RID: 955
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003BC RID: 956
		public const int AvatarListFieldNumber = 3;

		// Token: 0x040003BD RID: 957
		private static readonly FieldCodec<Avatar> _repeated_avatarList_codec = FieldCodec.ForMessage<Avatar>(26U, Avatar.Parser);

		// Token: 0x040003BE RID: 958
		private readonly RepeatedField<Avatar> avatarList_ = new RepeatedField<Avatar>();
	}
}
