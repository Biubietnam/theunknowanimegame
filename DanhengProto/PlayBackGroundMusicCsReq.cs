using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CA9 RID: 3241
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayBackGroundMusicCsReq : IMessage<PlayBackGroundMusicCsReq>, IMessage, IEquatable<PlayBackGroundMusicCsReq>, IDeepCloneable<PlayBackGroundMusicCsReq>, IBufferMessage
	{
		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x06009006 RID: 36870 RVA: 0x0017C658 File Offset: 0x0017A858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayBackGroundMusicCsReq> Parser
		{
			get
			{
				return PlayBackGroundMusicCsReq._parser;
			}
		}

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x06009007 RID: 36871 RVA: 0x0017C65F File Offset: 0x0017A85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayBackGroundMusicCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x06009008 RID: 36872 RVA: 0x0017C671 File Offset: 0x0017A871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayBackGroundMusicCsReq.Descriptor;
			}
		}

		// Token: 0x06009009 RID: 36873 RVA: 0x0017C678 File Offset: 0x0017A878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayBackGroundMusicCsReq()
		{
		}

		// Token: 0x0600900A RID: 36874 RVA: 0x0017C680 File Offset: 0x0017A880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayBackGroundMusicCsReq(PlayBackGroundMusicCsReq other) : this()
		{
			this.playMusicId_ = other.playMusicId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600900B RID: 36875 RVA: 0x0017C6A5 File Offset: 0x0017A8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayBackGroundMusicCsReq Clone()
		{
			return new PlayBackGroundMusicCsReq(this);
		}

		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x0600900C RID: 36876 RVA: 0x0017C6AD File Offset: 0x0017A8AD
		// (set) Token: 0x0600900D RID: 36877 RVA: 0x0017C6B5 File Offset: 0x0017A8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlayMusicId
		{
			get
			{
				return this.playMusicId_;
			}
			set
			{
				this.playMusicId_ = value;
			}
		}

		// Token: 0x0600900E RID: 36878 RVA: 0x0017C6BE File Offset: 0x0017A8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayBackGroundMusicCsReq);
		}

		// Token: 0x0600900F RID: 36879 RVA: 0x0017C6CC File Offset: 0x0017A8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayBackGroundMusicCsReq other)
		{
			return other != null && (other == this || (this.PlayMusicId == other.PlayMusicId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009010 RID: 36880 RVA: 0x0017C6FC File Offset: 0x0017A8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayMusicId != 0U)
			{
				num ^= this.PlayMusicId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x0017C73B File Offset: 0x0017A93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009012 RID: 36882 RVA: 0x0017C743 File Offset: 0x0017A943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009013 RID: 36883 RVA: 0x0017C74C File Offset: 0x0017A94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayMusicId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PlayMusicId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009014 RID: 36884 RVA: 0x0017C780 File Offset: 0x0017A980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayMusicId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlayMusicId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009015 RID: 36885 RVA: 0x0017C7BE File Offset: 0x0017A9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayBackGroundMusicCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayMusicId != 0U)
			{
				this.PlayMusicId = other.PlayMusicId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009016 RID: 36886 RVA: 0x0017C7EF File Offset: 0x0017A9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009017 RID: 36887 RVA: 0x0017C7F8 File Offset: 0x0017A9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayMusicId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400375E RID: 14174
		private static readonly MessageParser<PlayBackGroundMusicCsReq> _parser = new MessageParser<PlayBackGroundMusicCsReq>(() => new PlayBackGroundMusicCsReq());

		// Token: 0x0400375F RID: 14175
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003760 RID: 14176
		public const int PlayMusicIdFieldNumber = 2;

		// Token: 0x04003761 RID: 14177
		private uint playMusicId_;
	}
}
