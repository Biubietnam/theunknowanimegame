using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AAD RID: 2733
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Material0 : IMessage<Material0>, IMessage, IEquatable<Material0>, IDeepCloneable<Material0>, IBufferMessage
	{
		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x06007924 RID: 31012 RVA: 0x001410B0 File Offset: 0x0013F2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Material0> Parser
		{
			get
			{
				return Material0._parser;
			}
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x06007925 RID: 31013 RVA: 0x001410B7 File Offset: 0x0013F2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return Material0Reflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x06007926 RID: 31014 RVA: 0x001410C9 File Offset: 0x0013F2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Material0.Descriptor;
			}
		}

		// Token: 0x06007927 RID: 31015 RVA: 0x001410D0 File Offset: 0x0013F2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Material0()
		{
		}

		// Token: 0x06007928 RID: 31016 RVA: 0x001410D8 File Offset: 0x0013F2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Material0(Material0 other) : this()
		{
			this.expireTime_ = other.expireTime_;
			this.num_ = other.num_;
			this.tid_ = other.tid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007929 RID: 31017 RVA: 0x00141115 File Offset: 0x0013F315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Material0 Clone()
		{
			return new Material0(this);
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x0600792A RID: 31018 RVA: 0x0014111D File Offset: 0x0013F31D
		// (set) Token: 0x0600792B RID: 31019 RVA: 0x00141125 File Offset: 0x0013F325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong ExpireTime
		{
			get
			{
				return this.expireTime_;
			}
			set
			{
				this.expireTime_ = value;
			}
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x0600792C RID: 31020 RVA: 0x0014112E File Offset: 0x0013F32E
		// (set) Token: 0x0600792D RID: 31021 RVA: 0x00141136 File Offset: 0x0013F336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x0600792E RID: 31022 RVA: 0x0014113F File Offset: 0x0013F33F
		// (set) Token: 0x0600792F RID: 31023 RVA: 0x00141147 File Offset: 0x0013F347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Tid
		{
			get
			{
				return this.tid_;
			}
			set
			{
				this.tid_ = value;
			}
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x00141150 File Offset: 0x0013F350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Material0);
		}

		// Token: 0x06007931 RID: 31025 RVA: 0x00141160 File Offset: 0x0013F360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Material0 other)
		{
			return other != null && (other == this || (this.ExpireTime == other.ExpireTime && this.Num == other.Num && this.Tid == other.Tid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007932 RID: 31026 RVA: 0x001411BC File Offset: 0x0013F3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExpireTime != 0UL)
			{
				num ^= this.ExpireTime.GetHashCode();
			}
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.Tid != 0U)
			{
				num ^= this.Tid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x0014122D File Offset: 0x0013F42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x00141235 File Offset: 0x0013F435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x00141240 File Offset: 0x0013F440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Num != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Num);
			}
			if (this.ExpireTime != 0UL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.ExpireTime);
			}
			if (this.Tid != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Tid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x001412B8 File Offset: 0x0013F4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExpireTime != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpireTime);
			}
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
			}
			if (this.Tid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Tid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x00141328 File Offset: 0x0013F528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Material0 other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExpireTime != 0UL)
			{
				this.ExpireTime = other.ExpireTime;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			if (other.Tid != 0U)
			{
				this.Tid = other.Tid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x0014138C File Offset: 0x0013F58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x00141398 File Offset: 0x0013F598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 48U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Tid = input.ReadUInt32();
						}
					}
					else
					{
						this.ExpireTime = input.ReadUInt64();
					}
				}
				else
				{
					this.Num = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002E7F RID: 11903
		private static readonly MessageParser<Material0> _parser = new MessageParser<Material0>(() => new Material0());

		// Token: 0x04002E80 RID: 11904
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E81 RID: 11905
		public const int ExpireTimeFieldNumber = 6;

		// Token: 0x04002E82 RID: 11906
		private ulong expireTime_;

		// Token: 0x04002E83 RID: 11907
		public const int NumFieldNumber = 3;

		// Token: 0x04002E84 RID: 11908
		private uint num_;

		// Token: 0x04002E85 RID: 11909
		public const int TidFieldNumber = 10;

		// Token: 0x04002E86 RID: 11910
		private uint tid_;
	}
}
