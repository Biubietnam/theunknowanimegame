using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001145 RID: 4421
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShareData : IMessage<ShareData>, IMessage, IEquatable<ShareData>, IDeepCloneable<ShareData>, IBufferMessage
	{
		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x0600C530 RID: 50480 RVA: 0x002112BC File Offset: 0x0020F4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShareData> Parser
		{
			get
			{
				return ShareData._parser;
			}
		}

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x0600C531 RID: 50481 RVA: 0x002112C3 File Offset: 0x0020F4C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ShareDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x0600C532 RID: 50482 RVA: 0x002112D5 File Offset: 0x0020F4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShareData.Descriptor;
			}
		}

		// Token: 0x0600C533 RID: 50483 RVA: 0x002112DC File Offset: 0x0020F4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShareData()
		{
		}

		// Token: 0x0600C534 RID: 50484 RVA: 0x002112E4 File Offset: 0x0020F4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShareData(ShareData other) : this()
		{
			this.pBDKOKELGHL_ = other.pBDKOKELGHL_;
			this.kJMFMGPACLL_ = other.kJMFMGPACLL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C535 RID: 50485 RVA: 0x00211315 File Offset: 0x0020F515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShareData Clone()
		{
			return new ShareData(this);
		}

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x0600C536 RID: 50486 RVA: 0x0021131D File Offset: 0x0020F51D
		// (set) Token: 0x0600C537 RID: 50487 RVA: 0x00211325 File Offset: 0x0020F525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PBDKOKELGHL
		{
			get
			{
				return this.pBDKOKELGHL_;
			}
			set
			{
				this.pBDKOKELGHL_ = value;
			}
		}

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x0600C538 RID: 50488 RVA: 0x0021132E File Offset: 0x0020F52E
		// (set) Token: 0x0600C539 RID: 50489 RVA: 0x00211336 File Offset: 0x0020F536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KJMFMGPACLL
		{
			get
			{
				return this.kJMFMGPACLL_;
			}
			set
			{
				this.kJMFMGPACLL_ = value;
			}
		}

		// Token: 0x0600C53A RID: 50490 RVA: 0x0021133F File Offset: 0x0020F53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShareData);
		}

		// Token: 0x0600C53B RID: 50491 RVA: 0x0021134D File Offset: 0x0020F54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShareData other)
		{
			return other != null && (other == this || (this.PBDKOKELGHL == other.PBDKOKELGHL && this.KJMFMGPACLL == other.KJMFMGPACLL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C53C RID: 50492 RVA: 0x0021138C File Offset: 0x0020F58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PBDKOKELGHL != 0U)
			{
				num ^= this.PBDKOKELGHL.GetHashCode();
			}
			if (this.KJMFMGPACLL != 0U)
			{
				num ^= this.KJMFMGPACLL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C53D RID: 50493 RVA: 0x002113E4 File Offset: 0x0020F5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C53E RID: 50494 RVA: 0x002113EC File Offset: 0x0020F5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C53F RID: 50495 RVA: 0x002113F8 File Offset: 0x0020F5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KJMFMGPACLL != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.KJMFMGPACLL);
			}
			if (this.PBDKOKELGHL != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.PBDKOKELGHL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C540 RID: 50496 RVA: 0x00211454 File Offset: 0x0020F654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PBDKOKELGHL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PBDKOKELGHL);
			}
			if (this.KJMFMGPACLL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KJMFMGPACLL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C541 RID: 50497 RVA: 0x002114AC File Offset: 0x0020F6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShareData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PBDKOKELGHL != 0U)
			{
				this.PBDKOKELGHL = other.PBDKOKELGHL;
			}
			if (other.KJMFMGPACLL != 0U)
			{
				this.KJMFMGPACLL = other.KJMFMGPACLL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C542 RID: 50498 RVA: 0x002114FC File Offset: 0x0020F6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C543 RID: 50499 RVA: 0x00211508 File Offset: 0x0020F708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PBDKOKELGHL = input.ReadUInt32();
					}
				}
				else
				{
					this.KJMFMGPACLL = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004FA3 RID: 20387
		private static readonly MessageParser<ShareData> _parser = new MessageParser<ShareData>(() => new ShareData());

		// Token: 0x04004FA4 RID: 20388
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FA5 RID: 20389
		public const int PBDKOKELGHLFieldNumber = 6;

		// Token: 0x04004FA6 RID: 20390
		private uint pBDKOKELGHL_;

		// Token: 0x04004FA7 RID: 20391
		public const int KJMFMGPACLLFieldNumber = 4;

		// Token: 0x04004FA8 RID: 20392
		private uint kJMFMGPACLL_;
	}
}
