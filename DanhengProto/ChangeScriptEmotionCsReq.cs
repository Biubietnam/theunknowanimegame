using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001CB RID: 459
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChangeScriptEmotionCsReq : IMessage<ChangeScriptEmotionCsReq>, IMessage, IEquatable<ChangeScriptEmotionCsReq>, IDeepCloneable<ChangeScriptEmotionCsReq>, IBufferMessage
	{
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0003B2D7 File Offset: 0x000394D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChangeScriptEmotionCsReq> Parser
		{
			get
			{
				return ChangeScriptEmotionCsReq._parser;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x0003B2DE File Offset: 0x000394DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChangeScriptEmotionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0003B2F0 File Offset: 0x000394F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeScriptEmotionCsReq.Descriptor;
			}
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0003B2F7 File Offset: 0x000394F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeScriptEmotionCsReq()
		{
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x0003B2FF File Offset: 0x000394FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeScriptEmotionCsReq(ChangeScriptEmotionCsReq other) : this()
		{
			this.scriptId_ = other.scriptId_;
			this.targetEmotionType_ = other.targetEmotionType_;
			this.fPPEFBKBFDD_ = other.fPPEFBKBFDD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0003B33C File Offset: 0x0003953C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeScriptEmotionCsReq Clone()
		{
			return new ChangeScriptEmotionCsReq(this);
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0003B344 File Offset: 0x00039544
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x0003B34C File Offset: 0x0003954C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScriptId
		{
			get
			{
				return this.scriptId_;
			}
			set
			{
				this.scriptId_ = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0003B355 File Offset: 0x00039555
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x0003B35D File Offset: 0x0003955D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialEmotionType TargetEmotionType
		{
			get
			{
				return this.targetEmotionType_;
			}
			set
			{
				this.targetEmotionType_ = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x0003B366 File Offset: 0x00039566
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x0003B36E File Offset: 0x0003956E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FPPEFBKBFDD
		{
			get
			{
				return this.fPPEFBKBFDD_;
			}
			set
			{
				this.fPPEFBKBFDD_ = value;
			}
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0003B377 File Offset: 0x00039577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeScriptEmotionCsReq);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0003B388 File Offset: 0x00039588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeScriptEmotionCsReq other)
		{
			return other != null && (other == this || (this.ScriptId == other.ScriptId && this.TargetEmotionType == other.TargetEmotionType && this.FPPEFBKBFDD == other.FPPEFBKBFDD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0003B3E4 File Offset: 0x000395E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this.TargetEmotionType != HeartDialEmotionType.Peace)
			{
				num ^= this.TargetEmotionType.GetHashCode();
			}
			if (this.FPPEFBKBFDD != 0U)
			{
				num ^= this.FPPEFBKBFDD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0003B45B File Offset: 0x0003965B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0003B463 File Offset: 0x00039663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0003B46C File Offset: 0x0003966C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetEmotionType != HeartDialEmotionType.Peace)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.TargetEmotionType);
			}
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ScriptId);
			}
			if (this.FPPEFBKBFDD != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.FPPEFBKBFDD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0003B4E4 File Offset: 0x000396E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			if (this.TargetEmotionType != HeartDialEmotionType.Peace)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TargetEmotionType);
			}
			if (this.FPPEFBKBFDD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FPPEFBKBFDD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0003B554 File Offset: 0x00039754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeScriptEmotionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.TargetEmotionType != HeartDialEmotionType.Peace)
			{
				this.TargetEmotionType = other.TargetEmotionType;
			}
			if (other.FPPEFBKBFDD != 0U)
			{
				this.FPPEFBKBFDD = other.FPPEFBKBFDD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0003B5B8 File Offset: 0x000397B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0003B5C4 File Offset: 0x000397C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 48U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FPPEFBKBFDD = input.ReadUInt32();
						}
					}
					else
					{
						this.ScriptId = input.ReadUInt32();
					}
				}
				else
				{
					this.TargetEmotionType = (HeartDialEmotionType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040008A2 RID: 2210
		private static readonly MessageParser<ChangeScriptEmotionCsReq> _parser = new MessageParser<ChangeScriptEmotionCsReq>(() => new ChangeScriptEmotionCsReq());

		// Token: 0x040008A3 RID: 2211
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008A4 RID: 2212
		public const int ScriptIdFieldNumber = 6;

		// Token: 0x040008A5 RID: 2213
		private uint scriptId_;

		// Token: 0x040008A6 RID: 2214
		public const int TargetEmotionTypeFieldNumber = 2;

		// Token: 0x040008A7 RID: 2215
		private HeartDialEmotionType targetEmotionType_;

		// Token: 0x040008A8 RID: 2216
		public const int FPPEFBKBFDDFieldNumber = 7;

		// Token: 0x040008A9 RID: 2217
		private uint fPPEFBKBFDD_;
	}
}
