using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A75 RID: 2677
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MainMissionCustomValue : IMessage<MainMissionCustomValue>, IMessage, IEquatable<MainMissionCustomValue>, IDeepCloneable<MainMissionCustomValue>, IBufferMessage
	{
		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x060076A0 RID: 30368 RVA: 0x0013ACD3 File Offset: 0x00138ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MainMissionCustomValue> Parser
		{
			get
			{
				return MainMissionCustomValue._parser;
			}
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x060076A1 RID: 30369 RVA: 0x0013ACDA File Offset: 0x00138EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MainMissionCustomValueReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x060076A2 RID: 30370 RVA: 0x0013ACEC File Offset: 0x00138EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MainMissionCustomValue.Descriptor;
			}
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x0013ACF3 File Offset: 0x00138EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainMissionCustomValue()
		{
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x0013ACFC File Offset: 0x00138EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainMissionCustomValue(MainMissionCustomValue other) : this()
		{
			this.customValueList_ = ((other.customValueList_ != null) ? other.customValueList_.Clone() : null);
			this.mainMissionId_ = other.mainMissionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x0013AD48 File Offset: 0x00138F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainMissionCustomValue Clone()
		{
			return new MainMissionCustomValue(this);
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x060076A6 RID: 30374 RVA: 0x0013AD50 File Offset: 0x00138F50
		// (set) Token: 0x060076A7 RID: 30375 RVA: 0x0013AD58 File Offset: 0x00138F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionCustomValueList CustomValueList
		{
			get
			{
				return this.customValueList_;
			}
			set
			{
				this.customValueList_ = value;
			}
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x060076A8 RID: 30376 RVA: 0x0013AD61 File Offset: 0x00138F61
		// (set) Token: 0x060076A9 RID: 30377 RVA: 0x0013AD69 File Offset: 0x00138F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainMissionId
		{
			get
			{
				return this.mainMissionId_;
			}
			set
			{
				this.mainMissionId_ = value;
			}
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x0013AD72 File Offset: 0x00138F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MainMissionCustomValue);
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x0013AD80 File Offset: 0x00138F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MainMissionCustomValue other)
		{
			return other != null && (other == this || (object.Equals(this.CustomValueList, other.CustomValueList) && this.MainMissionId == other.MainMissionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x0013ADD0 File Offset: 0x00138FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.customValueList_ != null)
			{
				num ^= this.CustomValueList.GetHashCode();
			}
			if (this.MainMissionId != 0U)
			{
				num ^= this.MainMissionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x0013AE25 File Offset: 0x00139025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x0013AE2D File Offset: 0x0013902D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x0013AE38 File Offset: 0x00139038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainMissionId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MainMissionId);
			}
			if (this.customValueList_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CustomValueList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076B0 RID: 30384 RVA: 0x0013AE94 File Offset: 0x00139094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.customValueList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CustomValueList);
			}
			if (this.MainMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainMissionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076B1 RID: 30385 RVA: 0x0013AEEC File Offset: 0x001390EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MainMissionCustomValue other)
		{
			if (other == null)
			{
				return;
			}
			if (other.customValueList_ != null)
			{
				if (this.customValueList_ == null)
				{
					this.CustomValueList = new MissionCustomValueList();
				}
				this.CustomValueList.MergeFrom(other.CustomValueList);
			}
			if (other.MainMissionId != 0U)
			{
				this.MainMissionId = other.MainMissionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060076B2 RID: 30386 RVA: 0x0013AF54 File Offset: 0x00139154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x0013AF60 File Offset: 0x00139160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.customValueList_ == null)
						{
							this.CustomValueList = new MissionCustomValueList();
						}
						input.ReadMessage(this.CustomValueList);
					}
				}
				else
				{
					this.MainMissionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002D98 RID: 11672
		private static readonly MessageParser<MainMissionCustomValue> _parser = new MessageParser<MainMissionCustomValue>(() => new MainMissionCustomValue());

		// Token: 0x04002D99 RID: 11673
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D9A RID: 11674
		public const int CustomValueListFieldNumber = 11;

		// Token: 0x04002D9B RID: 11675
		private MissionCustomValueList customValueList_;

		// Token: 0x04002D9C RID: 11676
		public const int MainMissionIdFieldNumber = 10;

		// Token: 0x04002D9D RID: 11677
		private uint mainMissionId_;
	}
}
