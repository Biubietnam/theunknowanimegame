using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013BD RID: 5053
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockBackGroundMusicCsReq : IMessage<UnlockBackGroundMusicCsReq>, IMessage, IEquatable<UnlockBackGroundMusicCsReq>, IDeepCloneable<UnlockBackGroundMusicCsReq>, IBufferMessage
	{
		// Token: 0x17003F48 RID: 16200
		// (get) Token: 0x0600E146 RID: 57670 RVA: 0x00257974 File Offset: 0x00255B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockBackGroundMusicCsReq> Parser
		{
			get
			{
				return UnlockBackGroundMusicCsReq._parser;
			}
		}

		// Token: 0x17003F49 RID: 16201
		// (get) Token: 0x0600E147 RID: 57671 RVA: 0x0025797B File Offset: 0x00255B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockBackGroundMusicCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F4A RID: 16202
		// (get) Token: 0x0600E148 RID: 57672 RVA: 0x0025798D File Offset: 0x00255B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockBackGroundMusicCsReq.Descriptor;
			}
		}

		// Token: 0x0600E149 RID: 57673 RVA: 0x00257994 File Offset: 0x00255B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockBackGroundMusicCsReq()
		{
		}

		// Token: 0x0600E14A RID: 57674 RVA: 0x002579A7 File Offset: 0x00255BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockBackGroundMusicCsReq(UnlockBackGroundMusicCsReq other) : this()
		{
			this.unlockIds_ = other.unlockIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E14B RID: 57675 RVA: 0x002579D1 File Offset: 0x00255BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockBackGroundMusicCsReq Clone()
		{
			return new UnlockBackGroundMusicCsReq(this);
		}

		// Token: 0x17003F4B RID: 16203
		// (get) Token: 0x0600E14C RID: 57676 RVA: 0x002579D9 File Offset: 0x00255BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnlockIds
		{
			get
			{
				return this.unlockIds_;
			}
		}

		// Token: 0x0600E14D RID: 57677 RVA: 0x002579E1 File Offset: 0x00255BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockBackGroundMusicCsReq);
		}

		// Token: 0x0600E14E RID: 57678 RVA: 0x002579EF File Offset: 0x00255BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockBackGroundMusicCsReq other)
		{
			return other != null && (other == this || (this.unlockIds_.Equals(other.unlockIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E14F RID: 57679 RVA: 0x00257A24 File Offset: 0x00255C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E150 RID: 57680 RVA: 0x00257A58 File Offset: 0x00255C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E151 RID: 57681 RVA: 0x00257A60 File Offset: 0x00255C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E152 RID: 57682 RVA: 0x00257A69 File Offset: 0x00255C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockIds_.WriteTo(ref output, UnlockBackGroundMusicCsReq._repeated_unlockIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E153 RID: 57683 RVA: 0x00257A90 File Offset: 0x00255C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockIds_.CalculateSize(UnlockBackGroundMusicCsReq._repeated_unlockIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E154 RID: 57684 RVA: 0x00257AC9 File Offset: 0x00255CC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockBackGroundMusicCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockIds_.Add(other.unlockIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E155 RID: 57685 RVA: 0x00257AF7 File Offset: 0x00255CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E156 RID: 57686 RVA: 0x00257B00 File Offset: 0x00255D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockIds_.AddEntriesFrom(ref input, UnlockBackGroundMusicCsReq._repeated_unlockIds_codec);
				}
			}
		}

		// Token: 0x040059AE RID: 22958
		private static readonly MessageParser<UnlockBackGroundMusicCsReq> _parser = new MessageParser<UnlockBackGroundMusicCsReq>(() => new UnlockBackGroundMusicCsReq());

		// Token: 0x040059AF RID: 22959
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059B0 RID: 22960
		public const int UnlockIdsFieldNumber = 9;

		// Token: 0x040059B1 RID: 22961
		private static readonly FieldCodec<uint> _repeated_unlockIds_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x040059B2 RID: 22962
		private readonly RepeatedField<uint> unlockIds_ = new RepeatedField<uint>();
	}
}
