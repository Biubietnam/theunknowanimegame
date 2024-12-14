using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000867 RID: 2151
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GKHIKGFLEHO : IMessage<GKHIKGFLEHO>, IMessage, IEquatable<GKHIKGFLEHO>, IDeepCloneable<GKHIKGFLEHO>, IBufferMessage
	{
		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x06005F97 RID: 24471 RVA: 0x000FCDE8 File Offset: 0x000FAFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GKHIKGFLEHO> Parser
		{
			get
			{
				return GKHIKGFLEHO._parser;
			}
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x06005F98 RID: 24472 RVA: 0x000FCDEF File Offset: 0x000FAFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GKHIKGFLEHOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x06005F99 RID: 24473 RVA: 0x000FCE01 File Offset: 0x000FB001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GKHIKGFLEHO.Descriptor;
			}
		}

		// Token: 0x06005F9A RID: 24474 RVA: 0x000FCE08 File Offset: 0x000FB008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GKHIKGFLEHO()
		{
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x000FCE10 File Offset: 0x000FB010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GKHIKGFLEHO(GKHIKGFLEHO other) : this()
		{
			this.hNEPCEBMJKJ_ = other.hNEPCEBMJKJ_;
			this.buffId_ = other.buffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x000FCE41 File Offset: 0x000FB041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GKHIKGFLEHO Clone()
		{
			return new GKHIKGFLEHO(this);
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x06005F9D RID: 24477 RVA: 0x000FCE49 File Offset: 0x000FB049
		// (set) Token: 0x06005F9E RID: 24478 RVA: 0x000FCE51 File Offset: 0x000FB051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HNEPCEBMJKJ
		{
			get
			{
				return this.hNEPCEBMJKJ_;
			}
			set
			{
				this.hNEPCEBMJKJ_ = value;
			}
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x06005F9F RID: 24479 RVA: 0x000FCE5A File Offset: 0x000FB05A
		// (set) Token: 0x06005FA0 RID: 24480 RVA: 0x000FCE62 File Offset: 0x000FB062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x000FCE6B File Offset: 0x000FB06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GKHIKGFLEHO);
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x000FCE79 File Offset: 0x000FB079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GKHIKGFLEHO other)
		{
			return other != null && (other == this || (this.HNEPCEBMJKJ == other.HNEPCEBMJKJ && this.BuffId == other.BuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x000FCEB8 File Offset: 0x000FB0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HNEPCEBMJKJ != 0U)
			{
				num ^= this.HNEPCEBMJKJ.GetHashCode();
			}
			if (this.BuffId != 0U)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x000FCF10 File Offset: 0x000FB110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x000FCF18 File Offset: 0x000FB118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x000FCF24 File Offset: 0x000FB124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HNEPCEBMJKJ != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.HNEPCEBMJKJ);
			}
			if (this.BuffId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x000FCF7C File Offset: 0x000FB17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HNEPCEBMJKJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HNEPCEBMJKJ);
			}
			if (this.BuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x000FCFD4 File Offset: 0x000FB1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GKHIKGFLEHO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HNEPCEBMJKJ != 0U)
			{
				this.HNEPCEBMJKJ = other.HNEPCEBMJKJ;
			}
			if (other.BuffId != 0U)
			{
				this.BuffId = other.BuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x000FD024 File Offset: 0x000FB224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FAA RID: 24490 RVA: 0x000FD030 File Offset: 0x000FB230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BuffId = input.ReadUInt32();
					}
				}
				else
				{
					this.HNEPCEBMJKJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040024C7 RID: 9415
		private static readonly MessageParser<GKHIKGFLEHO> _parser = new MessageParser<GKHIKGFLEHO>(() => new GKHIKGFLEHO());

		// Token: 0x040024C8 RID: 9416
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024C9 RID: 9417
		public const int HNEPCEBMJKJFieldNumber = 1;

		// Token: 0x040024CA RID: 9418
		private uint hNEPCEBMJKJ_;

		// Token: 0x040024CB RID: 9419
		public const int BuffIdFieldNumber = 7;

		// Token: 0x040024CC RID: 9420
		private uint buffId_;
	}
}
