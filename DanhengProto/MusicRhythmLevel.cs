using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BE3 RID: 3043
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmLevel : IMessage<MusicRhythmLevel>, IMessage, IEquatable<MusicRhythmLevel>, IDeepCloneable<MusicRhythmLevel>, IBufferMessage
	{
		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x060086B1 RID: 34481 RVA: 0x00163941 File Offset: 0x00161B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmLevel> Parser
		{
			get
			{
				return MusicRhythmLevel._parser;
			}
		}

		// Token: 0x170025C8 RID: 9672
		// (get) Token: 0x060086B2 RID: 34482 RVA: 0x00163948 File Offset: 0x00161B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmLevelReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025C9 RID: 9673
		// (get) Token: 0x060086B3 RID: 34483 RVA: 0x0016395A File Offset: 0x00161B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmLevel.Descriptor;
			}
		}

		// Token: 0x060086B4 RID: 34484 RVA: 0x00163961 File Offset: 0x00161B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmLevel()
		{
		}

		// Token: 0x060086B5 RID: 34485 RVA: 0x00163969 File Offset: 0x00161B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmLevel(MusicRhythmLevel other) : this()
		{
			this.unlockLevel_ = other.unlockLevel_;
			this.isFullCombo_ = other.isFullCombo_;
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086B6 RID: 34486 RVA: 0x001639A6 File Offset: 0x00161BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmLevel Clone()
		{
			return new MusicRhythmLevel(this);
		}

		// Token: 0x170025CA RID: 9674
		// (get) Token: 0x060086B7 RID: 34487 RVA: 0x001639AE File Offset: 0x00161BAE
		// (set) Token: 0x060086B8 RID: 34488 RVA: 0x001639B6 File Offset: 0x00161BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UnlockLevel
		{
			get
			{
				return this.unlockLevel_;
			}
			set
			{
				this.unlockLevel_ = value;
			}
		}

		// Token: 0x170025CB RID: 9675
		// (get) Token: 0x060086B9 RID: 34489 RVA: 0x001639BF File Offset: 0x00161BBF
		// (set) Token: 0x060086BA RID: 34490 RVA: 0x001639C7 File Offset: 0x00161BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFullCombo
		{
			get
			{
				return this.isFullCombo_;
			}
			set
			{
				this.isFullCombo_ = value;
			}
		}

		// Token: 0x170025CC RID: 9676
		// (get) Token: 0x060086BB RID: 34491 RVA: 0x001639D0 File Offset: 0x00161BD0
		// (set) Token: 0x060086BC RID: 34492 RVA: 0x001639D8 File Offset: 0x00161BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x060086BD RID: 34493 RVA: 0x001639E1 File Offset: 0x00161BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmLevel);
		}

		// Token: 0x060086BE RID: 34494 RVA: 0x001639F0 File Offset: 0x00161BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmLevel other)
		{
			return other != null && (other == this || (this.UnlockLevel == other.UnlockLevel && this.IsFullCombo == other.IsFullCombo && this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060086BF RID: 34495 RVA: 0x00163A4C File Offset: 0x00161C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UnlockLevel != 0U)
			{
				num ^= this.UnlockLevel.GetHashCode();
			}
			if (this.IsFullCombo)
			{
				num ^= this.IsFullCombo.GetHashCode();
			}
			if (this.LevelId != 0U)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060086C0 RID: 34496 RVA: 0x00163ABD File Offset: 0x00161CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060086C1 RID: 34497 RVA: 0x00163AC5 File Offset: 0x00161CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086C2 RID: 34498 RVA: 0x00163AD0 File Offset: 0x00161CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.LevelId);
			}
			if (this.IsFullCombo)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsFullCombo);
			}
			if (this.UnlockLevel != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.UnlockLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086C3 RID: 34499 RVA: 0x00163B48 File Offset: 0x00161D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UnlockLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UnlockLevel);
			}
			if (this.IsFullCombo)
			{
				num += 2;
			}
			if (this.LevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060086C4 RID: 34500 RVA: 0x00163BAC File Offset: 0x00161DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmLevel other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UnlockLevel != 0U)
			{
				this.UnlockLevel = other.UnlockLevel;
			}
			if (other.IsFullCombo)
			{
				this.IsFullCombo = other.IsFullCombo;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060086C5 RID: 34501 RVA: 0x00163C10 File Offset: 0x00161E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086C6 RID: 34502 RVA: 0x00163C1C File Offset: 0x00161E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 64U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.UnlockLevel = input.ReadUInt32();
						}
					}
					else
					{
						this.IsFullCombo = input.ReadBool();
					}
				}
				else
				{
					this.LevelId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400339E RID: 13214
		private static readonly MessageParser<MusicRhythmLevel> _parser = new MessageParser<MusicRhythmLevel>(() => new MusicRhythmLevel());

		// Token: 0x0400339F RID: 13215
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033A0 RID: 13216
		public const int UnlockLevelFieldNumber = 13;

		// Token: 0x040033A1 RID: 13217
		private uint unlockLevel_;

		// Token: 0x040033A2 RID: 13218
		public const int IsFullComboFieldNumber = 8;

		// Token: 0x040033A3 RID: 13219
		private bool isFullCombo_;

		// Token: 0x040033A4 RID: 13220
		public const int LevelIdFieldNumber = 5;

		// Token: 0x040033A5 RID: 13221
		private uint levelId_;
	}
}
