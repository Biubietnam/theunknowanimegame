using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000109 RID: 265
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleTarget : IMessage<BattleTarget>, IMessage, IEquatable<BattleTarget>, IDeepCloneable<BattleTarget>, IBufferMessage
	{
		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x0002405C File Offset: 0x0002225C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleTarget> Parser
		{
			get
			{
				return BattleTarget._parser;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00024063 File Offset: 0x00022263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleTargetReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00024075 File Offset: 0x00022275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleTarget.Descriptor;
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0002407C File Offset: 0x0002227C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleTarget()
		{
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00024084 File Offset: 0x00022284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleTarget(BattleTarget other) : this()
		{
			this.id_ = other.id_;
			this.progress_ = other.progress_;
			this.totalProgress_ = other.totalProgress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x000240C1 File Offset: 0x000222C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleTarget Clone()
		{
			return new BattleTarget(this);
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x000240C9 File Offset: 0x000222C9
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x000240D1 File Offset: 0x000222D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x000240DA File Offset: 0x000222DA
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x000240E2 File Offset: 0x000222E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x000240EB File Offset: 0x000222EB
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x000240F3 File Offset: 0x000222F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TotalProgress
		{
			get
			{
				return this.totalProgress_;
			}
			set
			{
				this.totalProgress_ = value;
			}
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x000240FC File Offset: 0x000222FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleTarget);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0002410C File Offset: 0x0002230C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleTarget other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Progress == other.Progress && this.TotalProgress == other.TotalProgress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00024168 File Offset: 0x00022368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.TotalProgress != 0U)
			{
				num ^= this.TotalProgress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x000241D9 File Offset: 0x000223D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x000241E1 File Offset: 0x000223E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x000241EC File Offset: 0x000223EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			if (this.Progress != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Progress);
			}
			if (this.TotalProgress != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.TotalProgress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00024260 File Offset: 0x00022460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			if (this.TotalProgress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TotalProgress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000242D0 File Offset: 0x000224D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleTarget other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			if (other.TotalProgress != 0U)
			{
				this.TotalProgress = other.TotalProgress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00024334 File Offset: 0x00022534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00024340 File Offset: 0x00022540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TotalProgress = input.ReadUInt32();
						}
					}
					else
					{
						this.Progress = input.ReadUInt32();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000539 RID: 1337
		private static readonly MessageParser<BattleTarget> _parser = new MessageParser<BattleTarget>(() => new BattleTarget());

		// Token: 0x0400053A RID: 1338
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400053B RID: 1339
		public const int IdFieldNumber = 1;

		// Token: 0x0400053C RID: 1340
		private uint id_;

		// Token: 0x0400053D RID: 1341
		public const int ProgressFieldNumber = 2;

		// Token: 0x0400053E RID: 1342
		private uint progress_;

		// Token: 0x0400053F RID: 1343
		public const int TotalProgressFieldNumber = 3;

		// Token: 0x04000540 RID: 1344
		private uint totalProgress_;
	}
}
