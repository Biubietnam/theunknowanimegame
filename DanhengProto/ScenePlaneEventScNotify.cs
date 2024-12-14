using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001085 RID: 4229
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ScenePlaneEventScNotify : IMessage<ScenePlaneEventScNotify>, IMessage, IEquatable<ScenePlaneEventScNotify>, IDeepCloneable<ScenePlaneEventScNotify>, IBufferMessage
	{
		// Token: 0x17003542 RID: 13634
		// (get) Token: 0x0600BC88 RID: 48264 RVA: 0x001FC283 File Offset: 0x001FA483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ScenePlaneEventScNotify> Parser
		{
			get
			{
				return ScenePlaneEventScNotify._parser;
			}
		}

		// Token: 0x17003543 RID: 13635
		// (get) Token: 0x0600BC89 RID: 48265 RVA: 0x001FC28A File Offset: 0x001FA48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ScenePlaneEventScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x0600BC8A RID: 48266 RVA: 0x001FC29C File Offset: 0x001FA49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScenePlaneEventScNotify.Descriptor;
			}
		}

		// Token: 0x0600BC8B RID: 48267 RVA: 0x001FC2A3 File Offset: 0x001FA4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlaneEventScNotify()
		{
		}

		// Token: 0x0600BC8C RID: 48268 RVA: 0x001FC2AC File Offset: 0x001FA4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlaneEventScNotify(ScenePlaneEventScNotify other) : this()
		{
			this.hGKMPLEMCKC_ = ((other.hGKMPLEMCKC_ != null) ? other.hGKMPLEMCKC_.Clone() : null);
			this.getItemList_ = ((other.getItemList_ != null) ? other.getItemList_.Clone() : null);
			this.iBDCNJHEHHH_ = ((other.iBDCNJHEHHH_ != null) ? other.iBDCNJHEHHH_.Clone() : null);
			this.dFOMENDHKLM_ = ((other.dFOMENDHKLM_ != null) ? other.dFOMENDHKLM_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC8D RID: 48269 RVA: 0x001FC340 File Offset: 0x001FA540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlaneEventScNotify Clone()
		{
			return new ScenePlaneEventScNotify(this);
		}

		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x0600BC8E RID: 48270 RVA: 0x001FC348 File Offset: 0x001FA548
		// (set) Token: 0x0600BC8F RID: 48271 RVA: 0x001FC350 File Offset: 0x001FA550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList HGKMPLEMCKC
		{
			get
			{
				return this.hGKMPLEMCKC_;
			}
			set
			{
				this.hGKMPLEMCKC_ = value;
			}
		}

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x0600BC90 RID: 48272 RVA: 0x001FC359 File Offset: 0x001FA559
		// (set) Token: 0x0600BC91 RID: 48273 RVA: 0x001FC361 File Offset: 0x001FA561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList GetItemList
		{
			get
			{
				return this.getItemList_;
			}
			set
			{
				this.getItemList_ = value;
			}
		}

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x0600BC92 RID: 48274 RVA: 0x001FC36A File Offset: 0x001FA56A
		// (set) Token: 0x0600BC93 RID: 48275 RVA: 0x001FC372 File Offset: 0x001FA572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList IBDCNJHEHHH
		{
			get
			{
				return this.iBDCNJHEHHH_;
			}
			set
			{
				this.iBDCNJHEHHH_ = value;
			}
		}

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x0600BC94 RID: 48276 RVA: 0x001FC37B File Offset: 0x001FA57B
		// (set) Token: 0x0600BC95 RID: 48277 RVA: 0x001FC383 File Offset: 0x001FA583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList DFOMENDHKLM
		{
			get
			{
				return this.dFOMENDHKLM_;
			}
			set
			{
				this.dFOMENDHKLM_ = value;
			}
		}

		// Token: 0x0600BC96 RID: 48278 RVA: 0x001FC38C File Offset: 0x001FA58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScenePlaneEventScNotify);
		}

		// Token: 0x0600BC97 RID: 48279 RVA: 0x001FC39C File Offset: 0x001FA59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScenePlaneEventScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.HGKMPLEMCKC, other.HGKMPLEMCKC) && object.Equals(this.GetItemList, other.GetItemList) && object.Equals(this.IBDCNJHEHHH, other.IBDCNJHEHHH) && object.Equals(this.DFOMENDHKLM, other.DFOMENDHKLM) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC98 RID: 48280 RVA: 0x001FC41C File Offset: 0x001FA61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hGKMPLEMCKC_ != null)
			{
				num ^= this.HGKMPLEMCKC.GetHashCode();
			}
			if (this.getItemList_ != null)
			{
				num ^= this.GetItemList.GetHashCode();
			}
			if (this.iBDCNJHEHHH_ != null)
			{
				num ^= this.IBDCNJHEHHH.GetHashCode();
			}
			if (this.dFOMENDHKLM_ != null)
			{
				num ^= this.DFOMENDHKLM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC99 RID: 48281 RVA: 0x001FC49A File Offset: 0x001FA69A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BC9A RID: 48282 RVA: 0x001FC4A2 File Offset: 0x001FA6A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC9B RID: 48283 RVA: 0x001FC4AC File Offset: 0x001FA6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dFOMENDHKLM_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.DFOMENDHKLM);
			}
			if (this.iBDCNJHEHHH_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.IBDCNJHEHHH);
			}
			if (this.hGKMPLEMCKC_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.HGKMPLEMCKC);
			}
			if (this.getItemList_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.GetItemList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC9C RID: 48284 RVA: 0x001FC540 File Offset: 0x001FA740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hGKMPLEMCKC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HGKMPLEMCKC);
			}
			if (this.getItemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GetItemList);
			}
			if (this.iBDCNJHEHHH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IBDCNJHEHHH);
			}
			if (this.dFOMENDHKLM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DFOMENDHKLM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC9D RID: 48285 RVA: 0x001FC5C8 File Offset: 0x001FA7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScenePlaneEventScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hGKMPLEMCKC_ != null)
			{
				if (this.hGKMPLEMCKC_ == null)
				{
					this.HGKMPLEMCKC = new ItemList();
				}
				this.HGKMPLEMCKC.MergeFrom(other.HGKMPLEMCKC);
			}
			if (other.getItemList_ != null)
			{
				if (this.getItemList_ == null)
				{
					this.GetItemList = new ItemList();
				}
				this.GetItemList.MergeFrom(other.GetItemList);
			}
			if (other.iBDCNJHEHHH_ != null)
			{
				if (this.iBDCNJHEHHH_ == null)
				{
					this.IBDCNJHEHHH = new ItemList();
				}
				this.IBDCNJHEHHH.MergeFrom(other.IBDCNJHEHHH);
			}
			if (other.dFOMENDHKLM_ != null)
			{
				if (this.dFOMENDHKLM_ == null)
				{
					this.DFOMENDHKLM = new ItemList();
				}
				this.DFOMENDHKLM.MergeFrom(other.DFOMENDHKLM);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC9E RID: 48286 RVA: 0x001FC6A0 File Offset: 0x001FA8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC9F RID: 48287 RVA: 0x001FC6AC File Offset: 0x001FA8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 18U)
					{
						if (this.dFOMENDHKLM_ == null)
						{
							this.DFOMENDHKLM = new ItemList();
						}
						input.ReadMessage(this.DFOMENDHKLM);
						continue;
					}
					if (num == 42U)
					{
						if (this.iBDCNJHEHHH_ == null)
						{
							this.IBDCNJHEHHH = new ItemList();
						}
						input.ReadMessage(this.IBDCNJHEHHH);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						if (this.hGKMPLEMCKC_ == null)
						{
							this.HGKMPLEMCKC = new ItemList();
						}
						input.ReadMessage(this.HGKMPLEMCKC);
						continue;
					}
					if (num == 106U)
					{
						if (this.getItemList_ == null)
						{
							this.GetItemList = new ItemList();
						}
						input.ReadMessage(this.GetItemList);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CAD RID: 19629
		private static readonly MessageParser<ScenePlaneEventScNotify> _parser = new MessageParser<ScenePlaneEventScNotify>(() => new ScenePlaneEventScNotify());

		// Token: 0x04004CAE RID: 19630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CAF RID: 19631
		public const int HGKMPLEMCKCFieldNumber = 6;

		// Token: 0x04004CB0 RID: 19632
		private ItemList hGKMPLEMCKC_;

		// Token: 0x04004CB1 RID: 19633
		public const int GetItemListFieldNumber = 13;

		// Token: 0x04004CB2 RID: 19634
		private ItemList getItemList_;

		// Token: 0x04004CB3 RID: 19635
		public const int IBDCNJHEHHHFieldNumber = 5;

		// Token: 0x04004CB4 RID: 19636
		private ItemList iBDCNJHEHHH_;

		// Token: 0x04004CB5 RID: 19637
		public const int DFOMENDHKLMFieldNumber = 2;

		// Token: 0x04004CB6 RID: 19638
		private ItemList dFOMENDHKLM_;
	}
}
