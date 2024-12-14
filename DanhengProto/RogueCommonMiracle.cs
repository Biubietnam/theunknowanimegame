using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E59 RID: 3673
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonMiracle : IMessage<RogueCommonMiracle>, IMessage, IEquatable<RogueCommonMiracle>, IDeepCloneable<RogueCommonMiracle>, IBufferMessage
	{
		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x0600A3D6 RID: 41942 RVA: 0x001B8969 File Offset: 0x001B6B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonMiracle> Parser
		{
			get
			{
				return RogueCommonMiracle._parser;
			}
		}

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x0600A3D7 RID: 41943 RVA: 0x001B8970 File Offset: 0x001B6B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonMiracleReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x0600A3D8 RID: 41944 RVA: 0x001B8982 File Offset: 0x001B6B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonMiracle.Descriptor;
			}
		}

		// Token: 0x0600A3D9 RID: 41945 RVA: 0x001B8989 File Offset: 0x001B6B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonMiracle()
		{
		}

		// Token: 0x0600A3DA RID: 41946 RVA: 0x001B8991 File Offset: 0x001B6B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonMiracle(RogueCommonMiracle other) : this()
		{
			this.miracleInfo_ = ((other.miracleInfo_ != null) ? other.miracleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3DB RID: 41947 RVA: 0x001B89C6 File Offset: 0x001B6BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonMiracle Clone()
		{
			return new RogueCommonMiracle(this);
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x0600A3DC RID: 41948 RVA: 0x001B89CE File Offset: 0x001B6BCE
		// (set) Token: 0x0600A3DD RID: 41949 RVA: 0x001B89D6 File Offset: 0x001B6BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameRogueMiracle MiracleInfo
		{
			get
			{
				return this.miracleInfo_;
			}
			set
			{
				this.miracleInfo_ = value;
			}
		}

		// Token: 0x0600A3DE RID: 41950 RVA: 0x001B89DF File Offset: 0x001B6BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonMiracle);
		}

		// Token: 0x0600A3DF RID: 41951 RVA: 0x001B89ED File Offset: 0x001B6BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonMiracle other)
		{
			return other != null && (other == this || (object.Equals(this.MiracleInfo, other.MiracleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A3E0 RID: 41952 RVA: 0x001B8A20 File Offset: 0x001B6C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.miracleInfo_ != null)
			{
				num ^= this.MiracleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A3E1 RID: 41953 RVA: 0x001B8A5C File Offset: 0x001B6C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A3E2 RID: 41954 RVA: 0x001B8A64 File Offset: 0x001B6C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3E3 RID: 41955 RVA: 0x001B8A6D File Offset: 0x001B6C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.miracleInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MiracleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3E4 RID: 41956 RVA: 0x001B8AA0 File Offset: 0x001B6CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.miracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MiracleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A3E5 RID: 41957 RVA: 0x001B8AE0 File Offset: 0x001B6CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonMiracle other)
		{
			if (other == null)
			{
				return;
			}
			if (other.miracleInfo_ != null)
			{
				if (this.miracleInfo_ == null)
				{
					this.MiracleInfo = new GameRogueMiracle();
				}
				this.MiracleInfo.MergeFrom(other.MiracleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A3E6 RID: 41958 RVA: 0x001B8B34 File Offset: 0x001B6D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3E7 RID: 41959 RVA: 0x001B8B40 File Offset: 0x001B6D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.miracleInfo_ == null)
					{
						this.MiracleInfo = new GameRogueMiracle();
					}
					input.ReadMessage(this.MiracleInfo);
				}
			}
		}

		// Token: 0x04004308 RID: 17160
		private static readonly MessageParser<RogueCommonMiracle> _parser = new MessageParser<RogueCommonMiracle>(() => new RogueCommonMiracle());

		// Token: 0x04004309 RID: 17161
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400430A RID: 17162
		public const int MiracleInfoFieldNumber = 4;

		// Token: 0x0400430B RID: 17163
		private GameRogueMiracle miracleInfo_;
	}
}
