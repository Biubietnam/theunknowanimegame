using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000081 RID: 129
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyEventEffectNotify : IMessage<AlleyEventEffectNotify>, IMessage, IEquatable<AlleyEventEffectNotify>, IDeepCloneable<AlleyEventEffectNotify>, IBufferMessage
	{
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00010030 File Offset: 0x0000E230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyEventEffectNotify> Parser
		{
			get
			{
				return AlleyEventEffectNotify._parser;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00010037 File Offset: 0x0000E237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyEventEffectNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00010049 File Offset: 0x0000E249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyEventEffectNotify.Descriptor;
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00010050 File Offset: 0x0000E250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyEventEffectNotify()
		{
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00010058 File Offset: 0x0000E258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyEventEffectNotify(AlleyEventEffectNotify other) : this()
		{
			this.gJNHMOFJBJG_ = other.gJNHMOFJBJG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0001007D File Offset: 0x0000E27D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyEventEffectNotify Clone()
		{
			return new AlleyEventEffectNotify(this);
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00010085 File Offset: 0x0000E285
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x0001008D File Offset: 0x0000E28D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GJNHMOFJBJG
		{
			get
			{
				return this.gJNHMOFJBJG_;
			}
			set
			{
				this.gJNHMOFJBJG_ = value;
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00010096 File Offset: 0x0000E296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyEventEffectNotify);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000100A4 File Offset: 0x0000E2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyEventEffectNotify other)
		{
			return other != null && (other == this || (this.GJNHMOFJBJG == other.GJNHMOFJBJG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000100D4 File Offset: 0x0000E2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GJNHMOFJBJG != 0U)
			{
				num ^= this.GJNHMOFJBJG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00010113 File Offset: 0x0000E313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0001011B File Offset: 0x0000E31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00010124 File Offset: 0x0000E324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GJNHMOFJBJG != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GJNHMOFJBJG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00010158 File Offset: 0x0000E358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GJNHMOFJBJG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GJNHMOFJBJG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00010196 File Offset: 0x0000E396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyEventEffectNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GJNHMOFJBJG != 0U)
			{
				this.GJNHMOFJBJG = other.GJNHMOFJBJG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000101C7 File Offset: 0x0000E3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000101D0 File Offset: 0x0000E3D0
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
					this.GJNHMOFJBJG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400020C RID: 524
		private static readonly MessageParser<AlleyEventEffectNotify> _parser = new MessageParser<AlleyEventEffectNotify>(() => new AlleyEventEffectNotify());

		// Token: 0x0400020D RID: 525
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400020E RID: 526
		public const int GJNHMOFJBJGFieldNumber = 2;

		// Token: 0x0400020F RID: 527
		private uint gJNHMOFJBJG_;
	}
}
