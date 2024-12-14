using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BE5 RID: 3045
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmMaxDifficultyLevelsUnlockNotify : IMessage<MusicRhythmMaxDifficultyLevelsUnlockNotify>, IMessage, IEquatable<MusicRhythmMaxDifficultyLevelsUnlockNotify>, IDeepCloneable<MusicRhythmMaxDifficultyLevelsUnlockNotify>, IBufferMessage
	{
		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x060086CA RID: 34506 RVA: 0x00163D08 File Offset: 0x00161F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmMaxDifficultyLevelsUnlockNotify> Parser
		{
			get
			{
				return MusicRhythmMaxDifficultyLevelsUnlockNotify._parser;
			}
		}

		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x060086CB RID: 34507 RVA: 0x00163D0F File Offset: 0x00161F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmMaxDifficultyLevelsUnlockNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x060086CC RID: 34508 RVA: 0x00163D21 File Offset: 0x00161F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmMaxDifficultyLevelsUnlockNotify.Descriptor;
			}
		}

		// Token: 0x060086CD RID: 34509 RVA: 0x00163D28 File Offset: 0x00161F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmMaxDifficultyLevelsUnlockNotify()
		{
		}

		// Token: 0x060086CE RID: 34510 RVA: 0x00163D30 File Offset: 0x00161F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmMaxDifficultyLevelsUnlockNotify(MusicRhythmMaxDifficultyLevelsUnlockNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086CF RID: 34511 RVA: 0x00163D49 File Offset: 0x00161F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmMaxDifficultyLevelsUnlockNotify Clone()
		{
			return new MusicRhythmMaxDifficultyLevelsUnlockNotify(this);
		}

		// Token: 0x060086D0 RID: 34512 RVA: 0x00163D51 File Offset: 0x00161F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmMaxDifficultyLevelsUnlockNotify);
		}

		// Token: 0x060086D1 RID: 34513 RVA: 0x00163D5F File Offset: 0x00161F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmMaxDifficultyLevelsUnlockNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060086D2 RID: 34514 RVA: 0x00163D80 File Offset: 0x00161F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060086D3 RID: 34515 RVA: 0x00163DA6 File Offset: 0x00161FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060086D4 RID: 34516 RVA: 0x00163DAE File Offset: 0x00161FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086D5 RID: 34517 RVA: 0x00163DB7 File Offset: 0x00161FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086D6 RID: 34518 RVA: 0x00163DD0 File Offset: 0x00161FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060086D7 RID: 34519 RVA: 0x00163DF6 File Offset: 0x00161FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmMaxDifficultyLevelsUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060086D8 RID: 34520 RVA: 0x00163E13 File Offset: 0x00162013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086D9 RID: 34521 RVA: 0x00163E1C File Offset: 0x0016201C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040033A7 RID: 13223
		private static readonly MessageParser<MusicRhythmMaxDifficultyLevelsUnlockNotify> _parser = new MessageParser<MusicRhythmMaxDifficultyLevelsUnlockNotify>(() => new MusicRhythmMaxDifficultyLevelsUnlockNotify());

		// Token: 0x040033A8 RID: 13224
		private UnknownFieldSet _unknownFields;
	}
}
