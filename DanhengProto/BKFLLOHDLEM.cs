using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200012B RID: 299
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BKFLLOHDLEM : IMessage<BKFLLOHDLEM>, IMessage, IEquatable<BKFLLOHDLEM>, IDeepCloneable<BKFLLOHDLEM>, IBufferMessage
	{
		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x000286D4 File Offset: 0x000268D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BKFLLOHDLEM> Parser
		{
			get
			{
				return BKFLLOHDLEM._parser;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x000286DB File Offset: 0x000268DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BKFLLOHDLEMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x000286ED File Offset: 0x000268ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BKFLLOHDLEM.Descriptor;
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x000286F4 File Offset: 0x000268F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BKFLLOHDLEM()
		{
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x000286FC File Offset: 0x000268FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BKFLLOHDLEM(BKFLLOHDLEM other) : this()
		{
			this.isSuccess_ = other.isSuccess_;
			this.oAPJFLKLHEH_ = other.oAPJFLKLHEH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0002872D File Offset: 0x0002692D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BKFLLOHDLEM Clone()
		{
			return new BKFLLOHDLEM(this);
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00028735 File Offset: 0x00026935
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x0002873D File Offset: 0x0002693D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00028746 File Offset: 0x00026946
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x0002874E File Offset: 0x0002694E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OAPJFLKLHEH
		{
			get
			{
				return this.oAPJFLKLHEH_;
			}
			set
			{
				this.oAPJFLKLHEH_ = value;
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00028757 File Offset: 0x00026957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BKFLLOHDLEM);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00028765 File Offset: 0x00026965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BKFLLOHDLEM other)
		{
			return other != null && (other == this || (this.IsSuccess == other.IsSuccess && this.OAPJFLKLHEH == other.OAPJFLKLHEH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000287A4 File Offset: 0x000269A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this.OAPJFLKLHEH != 0U)
			{
				num ^= this.OAPJFLKLHEH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000287FC File Offset: 0x000269FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00028804 File Offset: 0x00026A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00028810 File Offset: 0x00026A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsSuccess)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsSuccess);
			}
			if (this.OAPJFLKLHEH != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.OAPJFLKLHEH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0002886C File Offset: 0x00026A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this.OAPJFLKLHEH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OAPJFLKLHEH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x000288B8 File Offset: 0x00026AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BKFLLOHDLEM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			if (other.OAPJFLKLHEH != 0U)
			{
				this.OAPJFLKLHEH = other.OAPJFLKLHEH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00028908 File Offset: 0x00026B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00028914 File Offset: 0x00026B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OAPJFLKLHEH = input.ReadUInt32();
					}
				}
				else
				{
					this.IsSuccess = input.ReadBool();
				}
			}
		}

		// Token: 0x040005D9 RID: 1497
		private static readonly MessageParser<BKFLLOHDLEM> _parser = new MessageParser<BKFLLOHDLEM>(() => new BKFLLOHDLEM());

		// Token: 0x040005DA RID: 1498
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005DB RID: 1499
		public const int IsSuccessFieldNumber = 7;

		// Token: 0x040005DC RID: 1500
		private bool isSuccess_;

		// Token: 0x040005DD RID: 1501
		public const int OAPJFLKLHEHFieldNumber = 11;

		// Token: 0x040005DE RID: 1502
		private uint oAPJFLKLHEH_;
	}
}
